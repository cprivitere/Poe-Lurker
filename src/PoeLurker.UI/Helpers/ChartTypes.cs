//-----------------------------------------------------------------------
// <copyright file="ChartTypes.cs" company="Wohs Inc.">
//     Copyright © Wohs Inc.
// </copyright>
//-----------------------------------------------------------------------

namespace PoeLurker.UI.Helpers;

using System.Collections.ObjectModel;

/// <summary>
/// Minimal inert chart data holders replacing the removed LiveCharts.NetCore
/// dependency. <see cref="ChartViewModelBase"/> has no XAML chart bindings and
/// no subclasses; these types keep its public surface compiling as inert data
/// holders. Do not extend: adopt LiveChartsCore v2 instead if charts return.
/// </summary>
public class SeriesCollection : Collection<object>
{
}

/// <summary>
/// Legend placement placeholder (only <see cref="LegendLocation.Bottom"/> is used).
/// </summary>
public enum LegendLocation
{
    None,
    Top,
    Bottom,
    Left,
    Right,
}

/// <summary>
/// Chart data-point placeholder.
/// </summary>
public class ChartPoint
{
}
