using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: weight (kg) and height (m)
            Console.WriteLine("Enter your weight in kilograms (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height in meters (m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            // BMI Calculation
            double bmi = weight / (height * height);
            Console.WriteLine("Your BMI is: {0:F2}",bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("Category: Underweight");
                Console.WriteLine("Associated Diseases: Malnutrition, Vitamin Deficiency, Osteoporosis.");
                Console.WriteLine("Suggested Treatment: Increase calorie intake, balanced diet, consult a nutritionist.");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Category: Normal weight");
                Console.WriteLine("Health Status: Maintain a healthy lifestyle to prevent future health problems.");
                Console.WriteLine("Suggested Treatment: Regular exercise, balanced diet, routine check-ups.");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Category: Overweight");
                Console.WriteLine("Associated Diseases: Heart disease, High blood pressure, Type 2 diabetes.");
                Console.WriteLine("Suggested Treatment: Physical activity, portion control, consult a dietitian.");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine("Category: Obese");
                Console.WriteLine("Associated Diseases: Cardiovascular diseases, Sleep apnea, Joint problems.");
                Console.WriteLine("Suggested Treatment: Weight management program, medical advice, possible surgery in extreme cases.");
            }

        }
    }
}
