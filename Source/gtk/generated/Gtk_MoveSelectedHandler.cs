// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void MoveSelectedHandler(object o, MoveSelectedArgs args);

	public class MoveSelectedArgs : GLib.SignalArgs {
		public int Distance{
			get {
				return (int) Args [0];
			}
		}

	}
}
