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


namespace CANAPE.Net.Tokens
{
    /// <summary>
    /// Enumeration of network status codes for use in the network connections
    /// </summary>
    public enum NetStatusCodes
    {
        /// <summary>
        /// Indicates the connection was successful
        /// </summary>
        Success,
        /// <summary>
        /// Indicates failed to look up a name
        /// </summary>
        NameLookup,
        /// <summary>
        /// Indicates failure to connect
        /// </summary>
        ConnectFailure,
        /// <summary>
        /// Indicates that authentication was requested
        /// </summary>
        AuthenticationRequired,
        /// <summary>
        /// Indicates connection blocked
        /// </summary>
        Blocked,
    }
}