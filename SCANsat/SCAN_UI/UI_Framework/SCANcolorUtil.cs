#region license
/*
 * [Scientific Committee on Advanced Navigation]
 * 			S.C.A.N. Satellite
 * 
 * SCANpalette - manages colors and palettes of colors
 *
 * Copyright (c)2014 technogeeky <technogeeky@gmail.com>;
 * Copyright (c)2014 (Your Name Here) <your email here>; see LICENSE.txt for licensing details.
*/
#endregion

using System;
using System.Text;
using UnityEngine;
using SCANsat.SCAN_Data;
using SCANsat.SCAN_Palettes;

namespace SCANsat.SCAN_UI.UI_Framework
{
	public class SCANcolorUtil
	{

		// Basic Colors
		// 	(these are here just so that all references to some color are the same throughout
		//		SCANsat)
		public static Color black 	= Color.black;
		public static Color32 Black = (Color32)black;
		public static Color white 	= Color.white;
		public static Color32 White = (Color32)white;
		public static Color red		= Color.red;
		public static Color32 Red = (Color32)red;
		public static Color grey		= Color.grey;
		public static Color32 Grey = (Color32)grey;
		public static Color clear	= Color.clear;
		public static Color32 Clear = new Color32(0, 0, 0, 0);
		public static Color magenta	= Color.magenta;
		public static Color yellow	= Color.yellow;
		public static Color cyan		= Color.cyan;
		public static Color blue		= Color.blue;
		public static Color green	= Color.green;
		public static Color mechjebYellow = new Color(1.0f, 0.56f, 0.0f);

		public static Color lerp (Color a, Color b, float t) {
			return Color.Lerp (a,b,t);
		}

		public static Color32 lerp(Color32 a, Color32 b, float t)
		{
			return Color32.Lerp(a, b, t);
		}

		// XKCD Colors
		// 	(these are collected here for the same reason)

		public static Color xkcd_Amber		= XKCDColors.Amber;
		public static Color xkcd_ArmyGreen		= XKCDColors.ArmyGreen;
		public static Color xkcd_PukeGreen		= XKCDColors.PukeGreen;
		public static Color xkcd_Lemon		= XKCDColors.Lemon;
		public static Color xkcd_OrangeRed 	= XKCDColors.OrangeRed;
		public static Color xkcd_CamoGreen		= XKCDColors.CamoGreen;
		public static Color xkcd_Marigold		= XKCDColors.Marigold;
		public static Color xkcd_Puce			= XKCDColors.Puce;
		public static Color xkcd_DarkTeal 		= XKCDColors.DarkTeal;
		public static Color xkcd_DarkPurple	= XKCDColors.DarkPurple;
		public static Color xkcd_DarkGrey		= XKCDColors.DarkGrey;
		public static Color xkcd_LightGrey		= XKCDColors.LightGrey;
		public static Color xkcd_PurplyPink	= XKCDColors.PurplyPink;
		public static Color xkcd_Magenta		= XKCDColors.Magenta;
		public static Color xkcd_YellowGreen	= XKCDColors.YellowGreen;
		public static Color xkcd_LightRed		= XKCDColors.LightRed;
		public static Color xkcd_Cerulean		= XKCDColors.Cerulean;
		public static Color xkcd_Yellow		= XKCDColors.Yellow;
		public static Color xkcd_Red			= XKCDColors.Red;
		public static Color xkcd_White		= XKCDColors.White;
		public static Color xkcd_DarkGreenAlpha = XKCDColors.DarkGreen * new Vector4(1, 1, 1, 0.4f);


		// colourblind barrier-free colours, according to Masataka Okabe and Kei Ito
		// http://jfly.iam.u-tokyo.ac.jp/color/

		public static Color cb_skyBlue 		= new Color(0.35f, 0.7f, 0.9f);		// sky blue
		public static Color cb_bluishGreen 	= new Color(0f, 0.6f, 0.5f);		// bluish green
		public static Color cb_yellow 		= new Color(0.95f, 0.9f, 0.25f);	// yellow
		public static Color cb_blue 			= new Color(0f, 0.45f, 0.7f);		// blue
		public static Color cb_vermillion 		= new Color(0.8f, 0.4f, 0f);		// vermillion
		public static Color cb_reddishPurple	= new Color(0.8f, 0.6f, 0.7f);		// reddish purple
		public static Color cb_orange 		= new Color(0.9f, 0.6f, 0f);		// orange

		public static Color32 CB_skyBlue = (Color32)cb_skyBlue;
		public static Color32 CB_bluishGreen = (Color32)cb_bluishGreen;
		public static Color32 CB_yellow = (Color32)cb_yellow;
		public static Color32 CB_blue = (Color32)cb_blue;
		public static Color32 CB_vermillion = (Color32)cb_vermillion;
		public static Color32 CB_reddishPurple = (Color32)cb_reddishPurple;
		public static Color32 CB_orange = (Color32)cb_orange;
        public static Color32 XKCD_DarkGreenAlpha = (Color32)(XKCDColors.DarkGreen * new Vector4(1, 1, 1, 0.4f));

        /* SOLARIZED colors: currently unused, so commented out */
        /*
		public static Color sol_base03 	= new Color32(0,43,54,255);
		public static Color sol_base02 	= new Color32(7,54,66,255);
		public static Color sol_base01 	= new Color32(88,110,117,255);
		public static Color sol_base00 	= new Color32(101,123,131,255);
		public static Color sol_base0 	= new Color32(131,148,150,255);
		public static Color sol_base1 	= new Color32(147,161,161,255);
		public static Color sol_base2 	= new Color32(238,232,213,255);
		public static Color sol_base3 	= new Color32(253,246,227,255);
		public static Color sol_yellow 	= new Color32(181,137,0,255);
		public static Color sol_orange 	= new Color32(203,75,22,255);
		public static Color sol_red 		= new Color32(45,220,50,255);
		public static Color sol_magenta 	= new Color32(211,54,130,255);
		public static Color sol_violet 	= new Color32(108,113,196,255);
		public static Color sol_blue 		= new Color32(38,139,210,255);
		public static Color sol_cyan 		= new Color32(42,161,152,255);
		public static Color sol_green 	= new Color32(133,153,0,255);
		*/
        public static Color[] heightGradient = {
			xkcd_ArmyGreen,
			xkcd_Yellow,
			xkcd_Red,
			xkcd_Magenta,
			xkcd_White,
			xkcd_White
		};

        public static Color32 combineColors(Color32[] colors)
        {
            float r = 0;
            float g = 0;
            float b = 0;
            float a = 0;

            int count = 0;

            for (int i = colors.Length - 1; i >= 0; i--)
            {
                Color32 c = colors[i];

                r += (c.r * c.r);
                g += (c.g * c.g);
                b += (c.b * c.b);
                a += (c.a * c.a);

                count++;
            }

            r /= count;
            g /= count;
            b /= count;
            a /= count;

            Color32 col = new Color32((byte)Mathf.Sqrt(r), (byte)Mathf.Sqrt(g), (byte)Mathf.Sqrt(b), (byte)Mathf.Sqrt(a));

            return col;
        }

		public static Color32[] redline;

		public static Color32[] small_redline;

		public static Color32 heightToColor(float val, bool color, SCANterrainConfig terrain, float min = 0, float max = 0, float range = 0, bool useCustomRange = false)
		{
			Color32[] c = terrain.ColorPal.ColorsArray;
			if (terrain.PalRev)
				c = terrain.ColorPal.ColorsReverse;
			if (useCustomRange)
			{
				if (color)
					return heightToColor(val, max, min, range, terrain.ClampTerrain, terrain.PalDis, c, true);
				else
					return heightToColor(val, max, min, range, terrain.PalDis);
			}
			else
			{
				if (color)
					return heightToColor(val, terrain.MaxTerrain, terrain.MinTerrain, terrain.TerrainRange, terrain.ClampTerrain, terrain.PalDis, c);
				else
					return heightToColor(val, terrain.MaxTerrain, terrain.MinTerrain, terrain.TerrainRange, terrain.PalDis);
			}
		}

		private static Color32 heightToColor(float val, float max, float min, float range, bool discrete)
		{
			Color32 c = Black;
			val -= min;
			if (SCAN_Settings_Config.Instance.TrueGreyScale)
			{
				val = Mathf.Clamp(val, 0, range) / range;
				c = lerp(Black, White, val);
			}
			else
			{
				if (discrete)
				{
					val = (GreyScalePalette.ColorsReverse.Length) * Mathf.Clamp(val, 0, range) / range;
					if (Math.Floor(val) > GreyScalePalette.ColorsReverse.Length - 1)
						val = GreyScalePalette.ColorsReverse.Length - 0.01f;
					c = GreyScalePalette.ColorsReverse[(int)Math.Floor(val)];
				}
				else
				{
					val = (GreyScalePalette.ColorsReverse.Length - 1) * Mathf.Clamp(val, 0, range) / range;
					if (Math.Floor(val) > GreyScalePalette.ColorsReverse.Length - 2)
						val = GreyScalePalette.ColorsReverse.Length - 1.01f;
					c = lerp(GreyScalePalette.ColorsReverse[(int)Math.Floor(val)], GreyScalePalette.ColorsReverse[(int)Math.Floor(val) + 1], val - (int)Math.Floor(val));
				}
			}
			return c;
		}

		internal static Color32 heightToColor(float val, float max, float min, float range, float? clamp, bool discrete, Color32[] p, bool useCustomRange = false)
		{
			Color32 c = Black;
			if (clamp != null)
			{
				if (!useCustomRange)
				{
					if (clamp < min + 10f)
						clamp = min + 10f;
					if (clamp > max - 10f)
						clamp = max - 10f;
				}

				if (val <= (float)clamp)
				{
					float newRange;

					if (useCustomRange)
					{
						if (max < (float)clamp)
							newRange = max - min;
						else
							newRange = (float)clamp - min;
					}
					else
						newRange = (float)clamp - min;

					val -= min;

					val = Mathf.Clamp(val, 0, newRange) / newRange;

					if (discrete)
						c = p[(int)Math.Round(val)];
					else
						c = lerp(p[0], p[1], val);
				}
				else
				{
					float newRange;

					if (useCustomRange)
					{
						if (min > (float)clamp)
						{
							newRange = max - min;
							val -= min;
						}
						else
						{
							newRange = max - (float)clamp;
							val -= (float)clamp;
						}
					}
					else
					{
						newRange = max - (float)clamp;
						val -= (float)clamp;
					}

					if (discrete)
					{
						val = (p.Length - 2) * Mathf.Clamp(val, 0, newRange) / newRange;
						if (Math.Floor(val) > p.Length - 3)
							val = p.Length - 2.01f;
						c = p[(int)Math.Floor(val) + 2];
					}
					else
					{
						val = (p.Length - 3) * Mathf.Clamp(val, 0, newRange) / newRange;
						if (Math.Floor(val) > p.Length - 4)
							val = p.Length - 3.01f;
						c = lerp(p[(int)Math.Floor(val) + 2], p[(int)Math.Floor(val) + 3], val - (int)Math.Floor(val));
					}
				}
			}
			else
			{
				val -= min;
				if (discrete)
				{
					val = (p.Length) * Mathf.Clamp(val, 0, range) / range;
					if (Math.Floor(val) > p.Length - 1)
						val = p.Length - 0.01f;
					c = p[(int)Math.Floor(val)];
				}
				else
				{
					val = (p.Length - 1) * Mathf.Clamp(val, 0, range) / range;
					if (Math.Floor(val) > p.Length - 2)
						val = p.Length - 1.01f;
					c = lerp(p[(int)Math.Floor(val)], p[(int)Math.Floor(val) + 1], val - (int)Math.Floor(val));
				}
			}
			return c;
		}

		public static string colorHex ( Color32 c ) {
			return string.Format("#{0}{1}{2}", c.r.ToString("X2"), c.g.ToString("X2"), c.b.ToString("X2"));
		}

		public static string coloredNoQuote(Color c, string text)
		{
			return string.Format("<color={0}>{1}</color>", colorHex(c), text);
		}

        public static string c_good_hex
        {
            get
            {
                if (SCANcontroller.controller.mainMapColor)
                    return "009980";
                else
                    return "59b3e6";
            }
        }

        public static string c_bad_hex
        {
            get { return "e69900"; }
        }

        public static string c_grey_hex
        {
            get { return "808080"; }
        }

        internal static Color c_good
		{
			get
			{
				if (SCANcontroller.controller.mainMapColor)
					return cb_bluishGreen;
				else
					return cb_skyBlue;
			}
		}
		internal static Color c_bad
		{
			get
			{
				return cb_orange;
			}
		}
		internal static Color c_ugly {
			get
			{
				if (SCANcontroller.controller.mainMapColor)
					return xkcd_LightRed;
				else
					return cb_yellow;
			}
		}

        internal static Color32 C_Good
        {
            get
            {
                if (SCANcontroller.controller.mainMapColor)
                    return CB_bluishGreen;
                else
                    return CB_skyBlue;
            }
        }
        internal static Color32 C_Bad
        {
            get
            {
                return CB_orange;
            }
        }
        private static SCANPaletteType currentPaletteSet;
		private static SCANPalette greyScalePalette;
		
		public static SCANPaletteType SetCurrentPalettesType(SCANPaletteKind type)
		{
			return SCANconfigLoader.SCANPalettes.GetPaletteType(type);
		}

		public static SCANPalette GreyScalePalette
		{
			get
			{
				if (greyScalePalette == null)
				{
					Color32[] c = new Color32[9] { new Color32(255, 255, 255, 255), new Color32(240, 240, 240, 255), new Color32(217, 217, 217, 255), new Color32(189, 189, 189, 255), new Color32(150, 150, 150, 255), new Color32(115, 115, 115, 255), new Color32(082, 082, 082, 255), new Color32(037, 037, 037, 255), new Color32(000, 0, 000, 255) };

					greyScalePalette = new SCANPalette(c, "GreyScalePalette", SCANPaletteKind.Fixed, c.Length);
				}

				return greyScalePalette;
			}
		}

		public static SCANPaletteType CurrentPalettes
		{
			get { return currentPaletteSet; }
			internal set
			{
				currentPaletteSet = value;
			}
		}

		public static string[] GetPaletteKindNames()
		{
			SCANPaletteKind[] v = (SCANPaletteKind[])Enum.GetValues(typeof(SCANPaletteKind));

			string[] r = new string[v.Length - 1];

			for (int i = 0; i < v.Length - 1; ++i)
				r[i] = v[i].ToString();

			return r;
		}

	}
}

