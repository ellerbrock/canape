//    CANAPE Network Testing Tool
//    Copyright (C) 2014 Context Information Security
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CANAPE.DataFrames
{
    /// <summary>
    /// An interface which species a method to serialize a value to and from a byte stream
    /// </summary>
    public interface IPrimitiveValue
    {
        /// <summary>
        /// Write the object to a stream
        /// </summary>
        /// <param name="writer">The writer to write the stream to</param>
        /// <param name="littleEndian">Whether the value should be little or big endian</param>
        void ToWriter(DataWriter writer, bool littleEndian);

        /// <summary>
        /// Read the object from a stream
        /// </summary>
        /// <param name="reader">The reader</param>
        /// <param name="littleEndian">Whether the value shouldbe little or big endian</param>
        void FromReader(DataReader reader, bool littleEndian);

        /// <summary>
        /// Get or set the value
        /// </summary>
        object Value { get; set; }
    }
}
