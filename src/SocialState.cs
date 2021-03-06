/*
Copyright (C) 2009 Pierre St Juste <ptony82@ufl.edu>, University of Florida

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*/

using System;
using System.Collections.Generic;

namespace SocialVPN {

  /**
   * This class defines the social state of the system.
   */
  public class SocialState {

    /**
     * The local certificate string
     */
    public string Certificate;

    /**
     * The local user's status
     */ 
    public string Status;

    /**
     * A message used by the browser
     */ 
    public string Message;

    /**
     * The local user.
     */
    public SocialUser LocalUser;

    /**
     * The list of friends.
     */
    public SocialUser[] Friends;

    /**
     * The list of blocked friends.
     */
    public List<string> BlockedFriends;

  }
}
