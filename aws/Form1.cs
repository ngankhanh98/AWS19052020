using Amazon.Polly;
using Amazon.Polly.Model;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio;
using NAudio.Wave;
using Amazon.Translate.Model;
using Amazon.Translate;
using Amazon;

namespace aws
{
    public partial class Form1 : Form
    {
        private String sourceLocation, targetLocation, detectTextImgLocation;
        private String sourceAdultContent;
        
        public Form1()
        {
            InitializeComponent();
        }

        private String LoadImage(object sender, EventArgs e, PictureBox img_source)
        {
            String fileLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*|PNG (*.png)|*png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = dialog.FileName;

                    img_source.ImageLocation = fileLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured!!!");
            }

            return fileLocation;
        }

        static Amazon.Rekognition.Model.Image ToBytesStream(string filename)
        {
            var image = new Amazon.Rekognition.Model.Image();

            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] data = null;
                data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                image.Bytes = new MemoryStream(data);
            }
            var client = new AmazonRekognitionClient();
            var request = new DetectLabelsRequest()
            {
                Image = image,
                MaxLabels = 10,
                MinConfidence = 77F
            };
            return image;
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            targetLocation = LoadImage(sender, e, img_target);
        }

        private void btn_find_faces_Click(object sender, EventArgs e)
        {
            var source = ToBytesStream($"{sourceLocation}");
            var target = ToBytesStream($"{targetLocation}");

            var client = new AmazonRekognitionClient();
            var request = new CompareFacesRequest { SourceImage = source, TargetImage = target, SimilarityThreshold = 90 };

            var response = client.CompareFaces(request);
            txt_result.Text = $"Found {response.FaceMatches.Count} matched faces with threshold 90%";           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_uploadAdultContent_Click(object sender, EventArgs e)
        {
            sourceAdultContent = LoadImage(sender, e, img_adultContent);
        }

        private void btn_DetectAdultContent_Click(object sender, EventArgs e)
        {
            txt_adultContent.Text = "";
            var source = ToBytesStream($"{sourceAdultContent}");
            var client = new AmazonRekognitionClient();
            var request = new DetectModerationLabelsRequest
            {
                Image = source
            };
            var response = client.DetectModerationLabels(request);

            txt_adultContent.Text = ($"Found {response.ModerationLabels.Count} labels: \n");
            foreach (var label in response.ModerationLabels)
            {
                txt_adultContent.Text += $"- {label.Name}\n";
            }
        }

        private void btn_speak_Click(object sender, EventArgs e)
        {
            var client = new AmazonPollyClient();
            var request = new SynthesizeSpeechRequest
            {
                Text = txt_Text.Text,
                OutputFormat = OutputFormat.Mp3,
                VoiceId = VoiceId.Joey
            };
            var response = client.SynthesizeSpeech(request);

            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var filename = $"{folder}{Guid.NewGuid()}.mp3";

            using (var fileStream = File.Create(filename))
            {
                response.AudioStream.CopyTo(fileStream);
                fileStream.Flush();
                fileStream.Close();
            }

           

            IWavePlayer waveOutDevice = new WaveOut();
            AudioFileReader audioFileReader = new AudioFileReader(filename);

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

        }

        private void btn_translate_Click(object sender, EventArgs e)
        {
            var accessKey = "ZHGHDaS6+s/WgJjY961PCgHbUzV+AcEDVJ5RirL3";
            var secretKey = "yfh7nvlO{bp}";

            var client = new AmazonTranslateClient(accessKey, secretKey, RegionEndpoint.APSoutheast1);

            var request = new TranslateTextRequest
            {
                Text = txt_langSource.Text,
                SourceLanguageCode = "en",
                TargetLanguageCode = "vi"
            };
            var result = client.TranslateText(request);

            txt_langTarget.Text = result.TranslatedText;
        }

        private void img_DetectTextImg_Click(object sender, EventArgs e)
        {
            detectTextImgLocation = LoadImage(sender, e, img_DetectTextImg);

            var image = ToBytesStream(@"detectTextImgLocation");
            var client = new AmazonRekognitionClient();
            var request = new DetectTextRequest
            {
                Image = image
            };

            var response = client.DetectText(request);
            txtDetectedText.Text= $"Found {response.TextDetections.Count} texts";

            foreach (var text in response.TextDetections)
            {
                txtDetectedText.Text += $"- {text.DetectedText}\n";
            }

        }

        private void btn_source_Click(object sender, EventArgs e)
        {
            sourceLocation = LoadImage(sender, e, img_source);
        }
    }
}
