// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.RenderPartGType))]
	public enum RenderPart {

		Foreground,
		Background,
		Underline,
		Strikethrough,
	}

	internal class RenderPartGType {
		[DllImport(NativeMethods.Pango, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_render_part_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_render_part_get_type ());
			}
		}
	}
#endregion
}
