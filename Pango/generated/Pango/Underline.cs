// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.UnderlineGType))]
	public enum Underline {

		None,
		Single,
		Double,
		Low,
		Error,
	}

	internal class UnderlineGType {
		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_underline_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_underline_get_type ());
			}
		}
	}
#endregion
}
