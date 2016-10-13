﻿namespace SPICA.Math3D
{
    struct RGBA
    {
        public byte R;
        public byte G;
        public byte B;
        public byte A;

        public RGBA(byte R, byte G, byte B, byte A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }

        public override string ToString()
        {
            return string.Format("R: {0} G: {1} B: {2} A: {3}", R, G, B, A);
        }
    }
}