using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_Task_3
{
    internal class insurance
    {
        private string _manufacturer;
        private string _modelType;
        private string _manufacturingDate;
        private float _strokeVolume;
        private int _ps;
        private int _kilometersPerYear;

        public insurance()
        {

        }

        public string Manufacturer
        {
            get => _manufacturer; 
            set => _manufacturer = value;
        }

        public string ModelType
        {
            get => _modelType;
            set => _modelType = value;
        }

        public string ManufacturingDate
        {
            get => _manufacturingDate; 
            set => _manufacturingDate = value;
        }

        public float StrokeVolume
        {
            get => _strokeVolume; 
            set => _strokeVolume = value;
        }

        public int PS
        {
            get => _ps; 
            set => _ps = value;
        }

        public int KilometersPerYear
        {
            get => _kilometersPerYear;
            set => _kilometersPerYear = value;
        }
    }
}
