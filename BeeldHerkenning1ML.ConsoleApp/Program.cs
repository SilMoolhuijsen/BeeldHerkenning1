using System;
using System.Diagnostics;
using BeeldHerkenning1ML.Model;
using static BeeldHerkenning1ML_ConsoleApp.MLModel1;

namespace Beeldherkenning1


{
    class Program
    {
        static void Main(string[] args)

        {

            Debug.WriteLine(" Object is not valid for this category.");

            // Add input data

            var input = new ModelInput();

            input.ImageSource = "C:\\Users\\silmo\\OneDrive\\Desktop\\School\\Informatica\\AI Image Recognition\\Image Datasets for Training\\wolves\\_106348479_mediaitem106348478.jpg";

            // Load  model and predict output of sample data

            ModelOutput result = ConsumeModel.Predict(input);

            Debug.WriteLine(result.Prediction);

            Console.WriteLine(result.Prediction);

        }
    }
}