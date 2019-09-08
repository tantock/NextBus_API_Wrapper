using System;

namespace NextBus_API_Wrapper
{
    public class Vehicle
    {
        string _VehicleID = "NULL";
        string _RouteTag = "NULL";
        string _DirTag = "NULL";
        float? _Lat = null;
        float? _Lon = null;
        int? _SecsSinceReport = null;
        bool? _Predictable = null;
        int? _Heading = null;
        double? _Speed = null;

        string VehicleID { get { return _VehicleID; } set { _VehicleID = value; } }
        string RouteTag { get { return _RouteTag ;} set{ _RouteTag  = value; } }
        string DirTag { get { return _DirTag ;} set{ _DirTag  = value; } }

        float? Lat { get { return _Lat ;} set{ _Lat  = value; } }
        float? Lon { get { return _Lon ;} set{ _Lon   = value; } }
        int? SecsSinceReport{ get { return _SecsSinceReport ;} set{ _SecsSinceReport  = value; } }
        bool? Predictable { get { return _Predictable ;} set{ _Predictable  = value; } }
        int? Heading { get { return _Heading ;} set{ _Heading  = value; } }
        double? Speed { get { return _Speed; } set { _Speed = value; } }
    }
}
