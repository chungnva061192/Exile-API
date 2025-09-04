using System;
using System.Globalization;
using System.Numerics;

namespace GameOffsets2.Native
{
	// Token: 0x02000092 RID: 146
	public struct Vector2i : IEquatable<Vector2i>
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002107 File Offset: 0x00000307
		public Vector2i(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000029CC File Offset: 0x00000BCC
		public int Length()
		{
			return (int)Math.Sqrt((double)this.LengthSqr());
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000029EC File Offset: 0x00000BEC
		public int LengthSqr()
		{
			return this.X * this.X + this.Y * this.Y;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002A1C File Offset: 0x00000C1C
		public void Normalize()
		{
			int num = this.Length();
			Vector2i.Divide(ref this, (float)num, out this);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002A3C File Offset: 0x00000C3C
		public Vector2i Normalized()
		{
			Vector2i result = this;
			result.Normalize();
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002A60 File Offset: 0x00000C60
		public int Distance(Vector2i v)
		{
			return Vector2i.Distance(ref this, ref v);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002A7C File Offset: 0x00000C7C
		public float DistanceF(Vector2i v)
		{
			return Vector2i.DistanceF(ref this, ref v);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002A98 File Offset: 0x00000C98
		public int Distance(ref Vector2i v)
		{
			return Vector2i.Distance(ref this, ref v);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public int DistanceSqr(Vector2i v)
		{
			return Vector2i.DistanceSqr(ref this, ref v);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public int DistanceSqr(ref Vector2i v)
		{
			return Vector2i.DistanceSqr(ref this, ref v);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002AEC File Offset: 0x00000CEC
		public Vector2 ToVector2()
		{
			return new Vector2((float)this.X, (float)this.Y);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B14 File Offset: 0x00000D14
		public bool Equals(Vector2i other)
		{
			return Vector2i.Equals(ref this, ref other);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002B30 File Offset: 0x00000D30
		public bool Equals(ref Vector2i other)
		{
			return Vector2i.Equals(ref this, ref other);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002B4C File Offset: 0x00000D4C
		public static bool Equals(ref Vector2i v1, ref Vector2i v2)
		{
			return v1.X == v2.X && v1.Y == v2.Y;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002B80 File Offset: 0x00000D80
		public static bool operator ==(Vector2i ls, Vector2i rs)
		{
			return Vector2i.Equals(ref ls, ref rs);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002B9C File Offset: 0x00000D9C
		public static bool operator !=(Vector2i ls, Vector2i rs)
		{
			return !Vector2i.Equals(ref ls, ref rs);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002BBC File Offset: 0x00000DBC
		public override bool Equals(object obj)
		{
			bool flag = obj == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2;
				try
				{
					flag2 = this.Equals((Vector2i)obj);
				}
				catch (InvalidCastException)
				{
					flag2 = false;
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002C04 File Offset: 0x00000E04
		public override int GetHashCode()
		{
			return this.X.GetHashCode() * 397 ^ this.Y.GetHashCode();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002C34 File Offset: 0x00000E34
		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "{{{0}, {1}}}", this.X, this.Y);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002C6C File Offset: 0x00000E6C
		public static Vector2i operator +(Vector2i ls, Vector2i rs)
		{
			Vector2i result;
			Vector2i.Add(ref ls, ref rs, out result);
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C8C File Offset: 0x00000E8C
		public static Vector2i operator -(Vector2i ls, Vector2i rs)
		{
			Vector2i result;
			Vector2i.Subtract(ref ls, ref rs, out result);
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002CAC File Offset: 0x00000EAC
		public static Vector2i operator -(Vector2i v)
		{
			v.X = -v.X;
			v.Y = -v.Y;
			return v;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002CDC File Offset: 0x00000EDC
		public static Vector2i operator *(Vector2i ls, Vector2i rs)
		{
			Vector2i result;
			Vector2i.Multiply(ref ls, ref rs, out result);
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002CFC File Offset: 0x00000EFC
		public static Vector2i operator *(Vector2i ls, int rs)
		{
			Vector2i result;
			Vector2i.Multiply(ref ls, (float)rs, out result);
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D1C File Offset: 0x00000F1C
		public static Vector2i operator *(Vector2i ls, float rs)
		{
			return new Vector2i((int)((float)ls.X * rs), (int)((float)ls.Y * rs));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002CDC File Offset: 0x00000EDC
		public static Vector2i operator /(Vector2i ls, Vector2i rs)
		{
			Vector2i result;
			Vector2i.Multiply(ref ls, ref rs, out result);
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D48 File Offset: 0x00000F48
		public static Vector2i operator /(Vector2i ls, int rs)
		{
			Vector2i result;
			Vector2i.Divide(ref ls, (float)rs, out result);
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002D68 File Offset: 0x00000F68
		public static implicit operator Vector2(Vector2i vector)
		{
			return vector.ToVector2();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002D84 File Offset: 0x00000F84
		public static void Add(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
		{
			result = new Vector2i
			{
				X = v1.X + v2.X,
				Y = v1.Y + v2.Y
			};
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002DCC File Offset: 0x00000FCC
		public static void Subtract(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
		{
			result = new Vector2i
			{
				X = v1.X - v2.X,
				Y = v1.Y - v2.Y
			};
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002E14 File Offset: 0x00001014
		public static void Multiply(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
		{
			result = new Vector2i
			{
				X = v1.X * v2.X,
				Y = v1.Y * v2.Y
			};
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002E5C File Offset: 0x0000105C
		public static Vector2i Multiply(Vector2i v1, Vector2i v2)
		{
			return new Vector2i
			{
				X = v1.X * v2.X,
				Y = v1.Y * v2.Y
			};
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002EA0 File Offset: 0x000010A0
		public static void Multiply(ref Vector2i v1, float scalar, out Vector2i result)
		{
			result = new Vector2i
			{
				X = (int)((float)v1.X * scalar),
				Y = (int)((float)v1.Y * scalar)
			};
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002EE0 File Offset: 0x000010E0
		public static void Divide(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
		{
			result = new Vector2i
			{
				X = v1.X / v2.X,
				Y = v1.Y / v2.Y
			};
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002118 File Offset: 0x00000318
		public static void Divide(ref Vector2i v1, float divisor, out Vector2i result)
		{
			Vector2i.Multiply(ref v1, 1f / divisor, out result);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002F28 File Offset: 0x00001128
		public static int Distance(ref Vector2i v1, ref Vector2i v2)
		{
			return (int)Math.Sqrt((double)Vector2i.DistanceSqr(ref v1, ref v2));
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002F48 File Offset: 0x00001148
		public static float DistanceF(ref Vector2i v1, ref Vector2i v2)
		{
			return (float)Math.Sqrt((double)Vector2i.DistanceSqr(ref v1, ref v2));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002F68 File Offset: 0x00001168
		public static int DistanceSqr(ref Vector2i v1, ref Vector2i v2)
		{
			int num = v1.X - v2.X;
			int num2 = v1.Y - v2.Y;
			return num * num + num2 * num2;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000212A File Offset: 0x0000032A
		public static void GetDirection(ref Vector2i from, ref Vector2i to, out Vector2i dir)
		{
			Vector2i.Subtract(ref to, ref from, out dir);
			dir.Normalize();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002FA0 File Offset: 0x000011A0
		public static Vector2i Min(Vector2i v1, Vector2i v2)
		{
			Vector2i result;
			Vector2i.Min(ref v1, ref v2, out result);
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000213D File Offset: 0x0000033D
		public static void Min(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
		{
			result = new Vector2i(Math.Min(v1.X, v2.X), Math.Min(v1.Y, v2.Y));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002FC0 File Offset: 0x000011C0
		public static Vector2i Max(Vector2i v1, Vector2i v2)
		{
			Vector2i result;
			Vector2i.Max(ref v1, ref v2, out result);
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002FE0 File Offset: 0x000011E0
		public static void Max(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
		{
			result = new Vector2i
			{
				X = Math.Max(v1.X, v2.X),
				Y = Math.Max(v1.Y, v2.Y)
			};
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000216D File Offset: 0x0000036D
		public static Vector2i Zero { get; } = new Vector2i(0, 0);

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002174 File Offset: 0x00000374
		public static Vector2i One { get; } = new Vector2i(1, 1);

		// Token: 0x06000054 RID: 84 RVA: 0x00003030 File Offset: 0x00001230
		public static int Dot(Vector2i v1, Vector2i v2)
		{
			return v1.X * v2.X + v1.Y * v2.Y;
		}

		// Token: 0x0400035E RID: 862
		public int X;

		// Token: 0x0400035F RID: 863
		public int Y;
	}
}
