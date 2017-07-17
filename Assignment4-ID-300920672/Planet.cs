using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Khim Tang
 * Date: July 12, 2017
 * Description: This is the Abstract Planet class
 * Version: 0.1 - Created the Abstract Planet class
 */

namespace Assignment4_ID_300920672
{
    /// <summary>
    /// This is the Abstract Planet class
    /// </summary>
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES
        public readonly double Diameter;
        public readonly double Mass;
        public int MoonCount { get { return this._moonCount; } set { this._moonCount = value; } }
        public readonly string Name;
        public double OrbitalPeriod { get { return this._orbitalPeriod; } set { this._orbitalPeriod = value; } }
        public int RingCount { get { return this._ringCount; } set { this._ringCount = value; } }
        public double RotationPeriod { get { return this._rotationPeriod; } set { this._rotationPeriod = value; } }

        #region Constructors

        /// <summary>
        /// This is the main constructor for the Planet class.
        /// It takes 3 parameters - name (string) - diameter (double) - mass (double)
        /// </summary>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        #endregion

        public override string ToString()
        {
            return string.Format("Name: " + Name, "Diameter: " + Diameter, "Mass: " + Mass);
        }
        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}