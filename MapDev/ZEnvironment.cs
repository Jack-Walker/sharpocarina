﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Drawing;

namespace SharpOcarina
{
    public class ColorWrapper
    {
        [XmlIgnore]
        private Color color;

        public ColorWrapper(Color color)
        {
            this.color = color;
        }

        public ColorWrapper() { }

        public int Argb
        {
            get { return color.ToArgb(); }
            set { color = Color.FromArgb(value); }
        }

        [XmlIgnore]
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    public class ZEnvironment
    {
        [XmlIgnore]
        private ColorWrapper _C1 = new ColorWrapper(), _C2 = new ColorWrapper(), _C3 = new ColorWrapper(), _C4 = new ColorWrapper(), _C5 = new ColorWrapper(), _FogColor = new ColorWrapper();
        [XmlIgnore]
        private ushort _FogDistance, _DrawDistance;

        public int C1
        {
            get { return _C1.Argb; }
            set { _C1.Argb = value; }
        }

        public int C2
        {
            get { return _C2.Argb; }
            set { _C2.Argb = value; }
        }

        public int C3
        {
            get { return _C3.Argb; }
            set { _C3.Argb = value; }
        }

        public int C4
        {
            get { return _C4.Argb; }
            set { _C4.Argb = value; }
        }

        public int C5
        {
            get { return _C5.Argb; }
            set { _C5.Argb = value; }
        }

        public int FogColor
        {
            get { return _FogColor.Argb; }
            set { _FogColor.Argb = value; }
        }

        [XmlIgnore]
        public Color C1C
        {
            get { return _C1.Color; }
            set { _C1.Color = value; }
        }

        [XmlIgnore]
        public Color C2C
        {
            get { return _C2.Color; }
            set { _C2.Color = value; }
        }

        [XmlIgnore]
        public Color C3C
        {
            get { return _C3.Color; }
            set { _C3.Color = value; }
        }

        [XmlIgnore]
        public Color C4C
        {
            get { return _C4.Color; }
            set { _C4.Color = value; }
        }

        [XmlIgnore]
        public Color C5C
        {
            get { return _C5.Color; }
            set { _C5.Color = value; }
        }

        [XmlIgnore]
        public Color FogColorC
        {
            get { return _FogColor.Color; }
            set { _FogColor.Color = value; }
        }

        public ushort FogDistance
        {
            get { return _FogDistance; }
            set { _FogDistance = value; }
        }

        public ushort DrawDistance
        {
            get { return _DrawDistance; }
            set { _DrawDistance = value; }
        }

        public ZEnvironment() { }

        public ZEnvironment(Color C1, Color C2, Color C3, Color C4, Color C5, Color FogColor, ushort FogDistance, ushort DrawDistance)
        {
            _C1 = new ColorWrapper(C1);
            _C2 = new ColorWrapper(C2);
            _C3 = new ColorWrapper(C3);
            _C4 = new ColorWrapper(C4);
            _C5 = new ColorWrapper(C5);
            _FogColor = new ColorWrapper(FogColor);
            _FogDistance = FogDistance;
            _DrawDistance = DrawDistance;
        }
    }
}
