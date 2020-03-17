using System;

namespace StayHome.Core
{
    public enum NavigationStackMode
    {
        NORMAL = 0,
        CLEAR_STACK,
        POP_PARENT,
        RELOAD,
        CLEAR_HIDDEN
    }
}
