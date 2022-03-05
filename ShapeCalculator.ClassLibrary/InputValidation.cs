//method needed to detect if choice is out of index bounds
using System;

namespace ShapeCalculator.ClassLibrary
{
    public class InputValidation
    {
        public string RawValue {get;set;}
        public double ValidatedDoubleValue{get;set;}
        public int ValidatedIntegerValue{get;set;}

        public double ValidateDoubleInput()
        {
            bool isDouble = false;
            bool isZeroOrGreater = false;
            while(!isDouble || !isZeroOrGreater)
            {
                GetRawValue();
                isDouble = ValidateAttributeInputAsDouble(this.RawValue);
                isZeroOrGreater = IsZeroOrGreater(this.ValidatedDoubleValue);
            }
            return ValidatedDoubleValue;
        }

        public int ValidateDimensionMenuChoice(int lowerBoundary, int upperBoundary)
        {
            bool isInteger = false;
            bool isRangeValid = false;
            while(!isInteger || !isRangeValid)
            {
                GetRawValue();
                isInteger = ValidateAttributeInputAsInteger(this.RawValue);
                isRangeValid = IsRangeValid(this.ValidatedIntegerValue, lowerBoundary, upperBoundary);
            }   
            return ValidatedIntegerValue;
        }

        public int ValidateShapeMenuChoice(int poolCount)
        {
            bool isInteger = false;
            bool isInMenuIndex = false;
            while(!isInteger || !isInMenuIndex)
            {
                GetRawValue();
                isInteger = ValidateAttributeInputAsInteger(this.RawValue);
                isInMenuIndex = IsShapeChoiceWithinIndex(this.ValidatedIntegerValue, poolCount);
            }   
            return ValidatedIntegerValue;
        }

        private bool IsShapeChoiceWithinIndex(int shapeChoice, int poolCount)
        {
            if(shapeChoice < 0 || shapeChoice > poolCount - 1)
            {
                Console.WriteLine($"Value entered: \"{shapeChoice}\" is not an option within the menu");
                return false;
            }
            return true;
        }
        
        private void GetRawValue()
        {
            this.RawValue = Console.ReadLine();
        }

        private bool ValidateAttributeInputAsDouble(string rawValue)
        {
            double validatedValue;
            bool isValid = double.TryParse(rawValue, out validatedValue);
            if(!isValid)
            {
                Console.WriteLine($"{rawValue} is not valid. Please re-enter a valid value");
                return false;
            }
            else
            {
                this.ValidatedDoubleValue = validatedValue;
                return true;
            }    
        }

        public bool ValidateAttributeInputAsInteger(string rawValue)
        {
            int validatedValue;
            bool isValid = Int32.TryParse(rawValue, out validatedValue);
            if(!isValid)
            {
                Console.WriteLine($"{rawValue} is not valid. Please re-enter a valid value");
                return false;
            }
            else
            {
                this.ValidatedIntegerValue = validatedValue;
                return true;
            }    
        }

        public bool IsZeroOrGreater(double validatedValue)
        {
            if(validatedValue >= 0)
            {
                return true;
            }
            return false;
        }

        public bool IsRangeValid(int validatedValue, int lowerBoundary, int upperBoundary)
        {
            if(validatedValue >= lowerBoundary && validatedValue <= upperBoundary)
            {
                return true;
            }
            return false;  
        }
    }
}