public class LineSegment
{
    private double start;
    private double end;

    public LineSegment()
    {
        start = 0;
        end = 1;
    }

    public LineSegment(double x1, double x2)
    {
        if (x1 < x2)
        {
            start = x1;
            end = x2;
        }
        else
        {
            start = x2;
            end = x1;
        }
    }

    public LineSegment(LineSegment other)
    {
        start = other.start;
        end = other.end;
    }

    public double Start
    {
        get { return start; }
        set
        {
            if (value <= end)
            {
                start = value;
            }
            else
            {
                start = end;
                end = value;
            }
        }
    }

    public double End
    {
        get { return end; }
        set
        {
            if (value >= start)
            {
                end = value;
            }
            else
            {
                end = start;
                start = value;
            }
        }
    }

    public double Length
    {
        get { return end - start; }
    }

    public bool Contains(double number)
    {
        if (number >= start && number <= end)
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
        seg.start = seg.start + 1;
        seg.end = seg.end + 1;
        return seg;
    }

    public static explicit operator int(LineSegment seg)
    {
        return (int)seg.start;
    }

    public static implicit operator double(LineSegment seg)
    {
        return seg.end;
    }

    public static LineSegment operator +(LineSegment seg, int d)
    {
        return new LineSegment(seg.start + d, seg.end + d);
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
        return "[" + start + ", " + end + "] длина = " + Length;
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

        return start == other.start && end == other.end;
    }

    public override int GetHashCode()
    {
        return start.GetHashCode() ^ end.GetHashCode();
    }
}
