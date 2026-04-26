public class LineSegment
{
    private double _start;
    private double _end;

    public LineSegment()
    {
        _start = 0;
        _end = 1;
    }

    public LineSegment(double x1, double x2)
    {
        if (x1 < x2)
        {
            _start = x1;
            _end = x2;
        }
        else
        {
            _start = x2;
            _end = x1;
        }
    }

    public LineSegment(LineSegment other)
    {
        _start = other._start;
        _end = other._end;
    }

    public double Start
    {
        get
        {
            return _start;
        }
        set
        {
            if (value <= _end)
            {
                _start = value;
            }
            else
            {
                _start = _end;
                _end = value;
            }
        }
    }

    public double End
    {
        get 
        { 
            return _end;
        }
        set
        {
            if (value >= _start)
            {
                _end = value;
            }
            else
            {
                _end = _start;
                _start = value;
            }
        }
    }

    public double Length
    {
        get
        {
            return _end - _start;
        }
    }

    public bool Contains(double number)
    {
        if (number >= _start && number <= _end)
        {
            return true;
        }
        return false;
    }

    public static double operator !(LineSegment seg)
    {
        return seg.Length;
    }

    public static LineSegment operator ++(LineSegment seg)
    {
        seg._start = seg._start + 1;
        seg._end = seg._end + 1;
        return seg;
    }

    public static explicit operator int(LineSegment seg)
    {
        return (int)seg._start;
    }

    public static implicit operator double(LineSegment seg)
    {
        return seg._end;
    }

    public static LineSegment operator +(LineSegment seg, int d)
    {
        return new LineSegment(seg._start + d, seg._end + d);
    }

    public static LineSegment operator +(int d, LineSegment seg)
    {
        return seg + d;
    }

    public static bool operator <(LineSegment seg, int number)
    {
        return seg.Contains(number);
    }

    public static bool operator >(LineSegment seg, int number)
    {
        return !(seg < number);
    }

    public override string ToString()
    {
        return "[" + _start + ", " + _end + "] длина = " + Length;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        LineSegment other = obj as LineSegment;
        if (other == null)
        {
            return false;
        }

        return _start == other._start && _end == other._end;
    }

    public override int GetHashCode()
    {
        return _start.GetHashCode() ^ _end.GetHashCode();
    }
}
