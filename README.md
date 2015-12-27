# PangoSharp
A C# wrapper of pango. Native libs are not included.

# License
__LGPLv3__  
Project PangoSharp is licensed under the LGPL v3 license.

    PangoSharp, A C# wrapper of pango which is a library for layout and rendering of text
    Copyright (C) 2015  Zou Wei, zwcloud@yeah.net, http://zwcloud.net


    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

The C# code files in project GLib and Pango is orginally Taken from Mono/[GTK#](https://github.com/mono/gtk-sharp/tree/master/pango)(Version 3.0.0), licensed under the GNU LGPL.

# Native dependencies

## Cairo
* libcairo.so

## Glib
* libglib-2.0.so
* libgobject-2.0.so

## Pango
* libpango-1.0.so
* libpangocairo-1.0.so
* libpangosharpglue-3.so

*PS: 
Version of these so files is not checked for now.
But I'm sure their version should be greater than that used in Gtk# 2.12.*