// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.EllipsizeModeGType))]
	public enum EllipsizeMode {

		None,
		Start,
		Middle,
		End,
	}

	internal class EllipsizeModeGType {
		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_ellipsize_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_ellipsize_mode_get_type ());
			}
		}
	}
#endregion
}
