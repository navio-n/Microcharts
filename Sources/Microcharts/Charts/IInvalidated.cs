using System;

namespace Microcharts.Charts
{
    public interface IInvalidated
    {
        event EventHandler Invalidated;
    }
}
