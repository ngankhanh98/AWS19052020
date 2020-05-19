using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS19052020
{
    class Program
    {
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

        static void Main(string[] args)
        {
            var source = ToBytesStream(@"C:\Users\ngank\Desktop\nhiet_ba4.jpg"); 			
            var target = ToBytesStream(@"C:\Users\ngank\Desktop\nhiet_ba_1.jpg");            

            var client = new AmazonRekognitionClient();
            var request = new CompareFacesRequest { SourceImage = source, TargetImage = target, SimilarityThreshold = 90 };

            var response = client.CompareFaces(request);
            Console.WriteLine($"Found {response.FaceMatches.Count} matched faces with threshold 90%");

            var sourceFace = response.SourceImageFace.BoundingBox;

            var matches = response.FaceMatches;
            foreach (var match in matches)
            {
                var face = match.Face.BoundingBox;

            }
        }
    }
}
