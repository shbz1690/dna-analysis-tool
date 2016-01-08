using System;
using System.Drawing;

namespace DNA
{
    class  Main_operation
    {

        /// <summary>
        /// To Draw string on Image
        /// </summary>
        /// <param name="word"></param>
        /// <param name="point"></param>
        /// <param name="g"></param>
        public static void draw_String_on_Image(string word, PointF point, Graphics g)
        {
            g.DrawString(word, new Font("italic", 8, FontStyle.Bold), Brushes.Black, point);
        }

        /// <summary>
        /// Draw The Counting Of Sequence
        /// </summary>
        /// <param name="seq"></param>
        /// <param name="revseq"></param>
        /// <param name="im"></param>
        /// <param name="g"></param>
        public static void draw_Seq_On_Image(string seq, int im, Graphics g, int Pos)
        {
            if (im * 50 + 50 <= seq.Length)
            {
                string subseq = seq.ToUpper().Substring(im * 50, 50);

                for (int k = 0; k < subseq.Length; k++)
                {
                    draw_String_on_Image(subseq[k].ToString(), new PointF(27 + k * 8, Pos), g);
                }

            }
            else if (im * 50 + 50 >= seq.Length)
            {
                string subseq = seq.ToUpper().Substring(im * 50);
                for (int k = 0; k < subseq.Length; k++)
                {
                    draw_String_on_Image(subseq[k].ToString(), new PointF(27 + k * 8, Pos), g);

                }


            }
        }

        public static void draw_SeqCount_On_Image(string seq, string revseq, int im, Graphics g)
        {
            if (im * 50 + 50 <= seq.Length)
            {
                string subseq = seq.ToUpper().Substring(im * 50, 50);
                int seqcount = subseq.Length + 50 * (int)im;
                draw_String_on_Image(seqcount.ToString(), new PointF(445, 45), g);
            }
            else if (im * 50 + 50 >= seq.Length)
            {
                string subseq = seq.ToUpper().Substring(im * 50);
                int seqcount = subseq.Length + 50 * (int)im;
                draw_String_on_Image(seqcount.ToString(), new PointF(445, 45), g);
            }

        }

        public static string Reversion(string Seq)
        {
            string Rev_Seq = "";
            char[] d = Seq.ToUpper().ToCharArray();
            Array.Reverse(d);
            for (int i = 0; i < d.Length; i++)
            {

                Rev_Seq += d[i];
            }

            return (string)Rev_Seq;

        }

        public static string DNA_complementry(string Seq)
        {
            /* this code in sequence toolStripButton in the complementry 
              ToolStripMenuItem to convert the DNA sequence
             from one strand to the other complementry strand 
            */

            string DNA_Comp = "";
            char[] d = Seq.ToUpper().ToCharArray();
            for (int n = 0; n < d.Length; ++n)
            {
                switch (d[n])
                {
                    case ('U'): d[n] = 'A'; break;
                    case ('A'): d[n] = 'U'; break;
                    case ('C'): d[n] = 'G'; break;
                    case ('G'): d[n] = 'C'; break;
                }
                DNA_Comp += Convert.ToString(d[n]);
            }

            return (string)DNA_Comp;
        }

        public static string DNA_To_RNA(string Seq)
        {
            /*this code exists in the (sequence) toolStripButton in the RNA 
                 ToolStripMenuItem to convert the sequence from 
                 DNA to RNA
                */
            string RNA = "";
            char[] d = Seq.ToUpper().ToCharArray();

            for (int n = 0; n < d.Length; ++n)
            {
                if (d[n] == 'T')
                {

                    d[n] = 'U';

                }
                RNA += Convert.ToString(d[n]);
            }

            return (string)RNA;
            
        }

        public static string RNA_complementry(string Seq)
        {
            /* this code exists in (sequence) toolStripButton in the complementry 
               ToolStripMenuItem to convert the RNA sequence
               from one strand to the other complementry strand 
            */
            string RNA_Comp = "";
            char[] d = Seq.ToUpper().ToCharArray();
            for (int n = 0; n < d.Length; ++n)
            {
                switch (d[n])
                {
                    case ('U'): d[n] = 'A'; break;
                    case ('A'): d[n] = 'U'; break;
                    case ('C'): d[n] = 'G'; break;
                    case ('G'): d[n] = 'C'; break;
                }
                RNA_Comp += Convert.ToString(d[n]);
            }

            return (string)RNA_Comp;
        }

        public static string RNA_To_DNA(string Seq)
        {
            /* this code exists in (sequence) toolStripButton in the RNA 
               ToolStripMenuItem to convert the sequence from 
               RNA to DNA
            */

            string DNA = "";
            char[] d = Seq.ToUpper().ToCharArray();
            for (int n = 0; n < d.Length; ++n)
            {
                if (d[n] == 'U')
                {
                    d[n] = 'T';
                }
                DNA += Convert.ToString(d[n]);
            }

            return (string)DNA;
        }

        public static float[] Nu_Percentage(string Seq)
        {
            /*this code calculates the percentage of every nucleotide(a,c,t or g)
              by calculate the total number of every necleotide and 
              then divides it on the length of the sequence to then send it to 
              the nucleotides form and then to the diagram and also it send 
              the report number (project)
            */

            string k = Seq.ToUpper();
            float gn = 0;
            float cn = 0;
            float tn = 0;
            float an = 0;
            float un = 0;
            for (int n = 0; n < k.Length; n++)
            {
                switch (k[n])
                {
                    case ('G'): gn += 1; break;
                    case ('C'): cn += 1; break;
                    case ('A'): an += 1; break;
                    case ('T'): tn += 1; break;
                    case ('U'): un += 1; break;
                }
            }

            float apr = an / k.Length * 100;
            float tpr = tn / k.Length * 100;
            float gpr = gn / k.Length * 100;
            float cpr = cn / k.Length * 100;
            float upr = un / k.Length * 100;
            //int ap = (int)apr;
            //int cp = (int)cpr;
            //int gp = (int)gpr;
            //int tp = (int)tpr;
            //int up = (int)upr;

            float[] Nu_No = new float[10];

            Nu_No[0] = an;
            Nu_No[1] = cn;
            Nu_No[2] = gn;
            Nu_No[3] = tn;
            Nu_No[4] = un;
            Nu_No[5] = apr;
            Nu_No[6] = cpr;
            Nu_No[7] = gpr;
            Nu_No[8] = tpr;
            Nu_No[9] = upr;

            


            return (float[])Nu_No; 
        }

        public static void Nu_Freq_On_Dist(string Seq, out int ap, out int cp, out int tp, out int gp)
        {


            string k = Seq.ToLower();
            float gn = 0;
            float cn = 0;
            float tn = 0;
            float an = 0;
            for (int n = 0; n < k.Length; n++)
            {
                switch (k[n])
                {
                    case ('g'): gn += 1; break;
                    case ('c'): cn += 1; break;
                    case ('a'): an += 1; break;
                    case ('t'): tn += 1; break;
                }
            }
            float apr = an / k.Length * 100;
            float tpr = tn / k.Length * 100;
            float gpr = gn / k.Length * 100;
            float cpr = cn / k.Length * 100;
            ap = (int)apr;
            cp = (int)cpr;
            gp = (int)gpr;
            tp = (int)tpr;


        }

        public static Image Nu_Per_Diagram(Image image, float a, float c, float g, float t)
        {
            using (Graphics pic = Graphics.FromImage(image))
            {
                Pen pa = new Pen(Color.Blue, 12);
                pic.DrawLine(pa, 90, 250, 90, 250 - 2 * a);
                pic.DrawString(Convert.ToString(a) + "%", new Font("italic", 12), Brushes.Black, new PointF(80, 230 - 2 * a));

                Pen pc = new Pen(Color.Red, 12);
                pic.DrawLine(pc, 150, 250, 150, 250 - 2 * c);
                pic.DrawString(Convert.ToString(c) + "%", new Font("italic", 12), Brushes.Black, new PointF(140, 230 - 2 * c));

                Pen pt = new Pen(Color.Green, 12);
                pic.DrawLine(pt, 210, 250, 210, 250 - 2 * t);
                pic.DrawString(Convert.ToString(t) + "%", new Font("italic", 12), Brushes.Black, new PointF(200, 230 - 2 * t));

                Pen pg = new Pen(Color.Navy, 12);
                pic.DrawLine(pg, 270, 250, 270, 250 - 2 * g);
                pic.DrawString(Convert.ToString(g) + "%", new Font("italic", 12), Brushes.Black, new PointF(260, 230 - 2 * g));


            }

            return (Image)image;

        }

        /// <summary>
        /// To Return the Melting Tm Value 
        /// </summary>
        /// <param name="Sequence"></param>
        /// <returns></returns>
        public static int DNA_Melting_Temp(string Sequence)
        {
            int GC_Content;
            int AT_Content;
            GC_AT_Content(Sequence, out GC_Content, out AT_Content);
            int Melt = 4 * GC_Content + 2 * AT_Content;
            return Melt;
        }

        public static void G_C_A_T_Content(string Seq, out int A, out int C, out int G, out int T)
        {
            int g = 0;
            int a = 0;
            int c = 0;
            int t = 0;
            for (int i = 0; i < Seq.Length; i++)
            {
                if (Seq[i] == 'a')
                    a++;
                else if (Seq[i] == 't')
                    t++;
                else if (Seq[i] == 'c')
                    c++;
                else if (Seq[i] == 'g')
                    g++;
            }
            G = g;
            C = c;
            T = t;
            A = a;
        }

        public static double DNA_MW(string Seq)
        {
            int a = 0;
            int c = 0;
            int g = 0;
            int t = 0;
            G_C_A_T_Content(Seq, out a, out c, out g, out t);
            double MW = 329.2 * g + 313.2 * a + 304.2 * t + 289.2 * c;
            return MW;
        }

        public static void GC_AT_Content(string Seq, out int GC_Content, out int AT_Content)
        {
            int gc = 0;
            int at = 0;
            for (int s = 0; s < Seq.Length; s++)
            {
                if (Seq[s] == 'C' || Seq[s] == 'G')
                    gc++;
                if (Seq[s] == 'A' || Seq[s] == 'T')
                    at++;
            }
            GC_Content = gc;
            AT_Content = at;
        }
    }
}
