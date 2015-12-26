using System;
namespace Demo01_Shape
{
    class Program
    {
        const int RADIUS = 150;
        const int N_WORDS = 5;
        const string FONT = "Sans Bold 27";

        static int Main(string[] args)
        {
            Cairo.Context cr;
            string text, fileName;
            Cairo.Surface surface;

            if(args.Length != 2)
            {
                Console.WriteLine("Usage: " + AppDomain.CurrentDomain.FriendlyName + "<text> <output file name>");
				Console.ReadKey();
				return 1;
            }

			text = args[0];
            fileName = args[1];

            surface = new Cairo.ImageSurface(Cairo.Format.ARGB32, 2*RADIUS, 2*RADIUS);

            cr = new Cairo.Context(surface);

            cr.SetSourceRGB(1.0, 1.0, 1.0);
            cr.Paint();
            DrawText(cr, text);

            surface.WriteToPng(fileName);

            if(surface.Status != Cairo.Status.Success)
            {
                Console.WriteLine("Could not save png to '{0}'", fileName);
				Console.ReadKey();
                return 1;
            }

            surface.Dispose();
            cr.Dispose();

			Console.ReadKey();
            return 0;
        }

		static void DrawText(Cairo.Context cr, string text)
        {
            Pango.Layout layout;
            Pango.FontDescription desc;

            //Center coordinates on the middle of the region we are drawing
            cr.Translate(RADIUS, RADIUS);

            //Create a PangoLayout, set the font and text
			layout = Pango.CairoHelper.CreateLayout(cr);
			layout.SetText(text);
            desc = Pango.FontDescription.FromString(FONT);
            layout.FontDescription = desc;
            desc.Dispose();

            //Draw the layout N_WORDS times in a circle
            for (int i = 0; i < N_WORDS; i++)
            {
                int width, height;
                double angle = (360.0*i)/N_WORDS;
                double red;

                cr.Save();

                //Gradient from red at angle == 60 to blue at angle == 240
                red = (1 + Math.Cos((angle - 60)*Math.PI/180f))/2;
                cr.SetSourceRGB(red, 0, 1.0 - red);
                cr.Rotate(angle*Math.PI/180);

                //Inform Pango to re-layout the text with the new transformation
                Pango.CairoHelper.UpdateLayout(cr, layout);

                layout.GetSize(out width, out height);
                cr.MoveTo(-(width/Pango.Scale.PangoScale)/2, -RADIUS);
                Pango.CairoHelper.ShowLayout(cr, layout);

                cr.Restore();
            }

            layout.Dispose();
        }
    }
}
