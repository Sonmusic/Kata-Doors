﻿using System;

namespace DoorClass
{
    public class Door
    {
        public string Key;
        public bool open = false;
        public bool closed = false;
        public bool unlocked = false;
        public bool locked = false;

        public Door ClosedAndUnlocked(string key)
        {
            Key = key;
            closed = true;
            unlocked = true;
            return this;
        }
        public Door Open()
        {
            if((closed == true) && (locked == false) && (unlocked == true))
            {
                closed = false;
                open = true;
                return this;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public bool IsOpen()
        {
            if(open == true)
            {
                return true;
            }
            else { return false; }
        }
    }
}
