using System.IO;
using UnityEngine;

public class Trailer2 : Destructible
{
	public Vector3Int DAT_A8;

	public Vector3Int DAT_B4;

	public Vehicle DAT_C0;

	public Wheel[] DAT_C4 = new Wheel[2];

	public short id2;

	protected override void Start()
	{
		base.Start();
	}

	protected override void Update()
	{
		base.Update();
	}

	public override uint OnCollision(HitDetection hit)
	{
		if (DAT_C0 == null || ((DAT_C0.flags | flags) & 0x4000000) == 0)
		{
			return FUN_440(hit);
		}
		return 0u;
	}

	public override uint UpdateW(int arg1, int arg2)
	{
		uint result;
		switch (arg1)
		{
		case 0:
			if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id2 == -1 || (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id2 > 0))
			{
				FUN_484();
			}
			if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && id2 == -1)
			{
				ClientSend.TrailerTransform(vTransform);
			}
			else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id2 > 0)
			{
				ClientSend.TrailerTransformAI(id2, vTransform);
			}
			result = 0u;
			break;
		default:
			result = 0u;
			break;
		case 2:
			FUN_4DC94();
			if (GameManager.instance.gameMode >= _GAME_MODE.Versus2 && id2 == -1)
			{
				ClientSend.TrailerDetach();
			}
			else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id2 > 0)
			{
				ClientSend.TrailerDetachAI(id2);
			}
			result = 0u;
			break;
		case 8:
			if (DAT_C0 == null || ((DAT_C0.flags | flags) & 0x4000000) == 0)
			{
				if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id2 == -1)
				{
					if (FUN_32B90((uint)arg2) && GameManager.instance.gameMode >= _GAME_MODE.Versus2)
					{
						ClientSend.TrailerDetach();
					}
				}
				else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id2 > 0 && FUN_32B90((uint)arg2))
				{
					ClientSend.TrailerDetachAI(id2);
				}
			}
			result = 0u;
			break;
		case 9:
			result = 0u;
			if (arg2 != 0)
			{
				Vehicle dAT_C = DAT_C0;
				if (dAT_C != null)
				{
					dAT_C.DAT_A6 -= DAT_A6;
				}
				GameManager.instance.FUN_309A0(this);
				result = uint.MaxValue;
			}
			break;
		}
		return result;
	}

	private uint FUN_440(HitDetection param1)
	{
		if (DAT_C0 == null)
		{
			if (GameManager.instance.gameMode < _GAME_MODE.Versus2 || id2 == -1)
			{
				if (FUN_32CF0(param1) && GameManager.instance.gameMode == _GAME_MODE.Versus2)
				{
					ClientSend.TrailerDetach();
				}
			}
			else if (GameManager.instance.gameMode > _GAME_MODE.Versus2 && DiscordController.IsOwner() && id2 > 0 && FUN_32CF0(param1))
			{
				ClientSend.TrailerDetachAI(id2);
			}
			return 0u;
		}
		return (uint)DAT_C0.FUN_3B424(this, param1);
	}

	private void FUN_484()
	{
		Vehicle dAT_C = DAT_C0;
		if (dAT_C == null)
		{
			vCollider.reader.Seek(4L, SeekOrigin.Current);
			FUN_2B4F8(vCollider.reader);
			vCollider.reader.Seek(-4L, SeekOrigin.Current);
			physics1.X = physics1.X * 4032 >> 12;
			physics1.Y = physics1.Y * 4032 >> 12;
			physics1.Z = physics1.Z * 4032 >> 12;
		}
		else if (((dAT_C.flags | flags) & 0x4000000) == 0)
		{
			if ((dAT_C.flags & 0x4000) != 0)
			{
				VigTransform transform = FUN_2AEAC();
				Vector3Int vector3Int = Utilities.FUN_24148(dAT_C.vTransform, DAT_B4);
				Vector3Int vector3Int2 = Utilities.FUN_24304(vTransform, vector3Int);
				Vector3Int vector3Int3 = Utilities.FUN_24148(transform, DAT_A8);
				vector3Int3.x = (vector3Int2.x - DAT_A8.x) * 128 - vector3Int3.x;
				if (vector3Int3.x < 0)
				{
					vector3Int3.x += 7;
				}
				Vector3Int vector3Int4 = default(Vector3Int);
				vector3Int4.x = vector3Int3.x >> 3;
				vector3Int3.y = (vector3Int2.y - DAT_A8.y) * 128 - vector3Int3.y;
				if (vector3Int3.y < 0)
				{
					vector3Int3.y += 7;
				}
				vector3Int4.y = vector3Int3.y >> 3;
				vector3Int3.z = (vector3Int2.z - DAT_A8.z) * 128 - vector3Int3.z;
				if (vector3Int3.z < 0)
				{
					vector3Int3.z += 7;
				}
				vector3Int4.z = vector3Int3.z >> 3;
				int num = vector3Int4.x;
				if (vector3Int4.x < 0)
				{
					num = -vector3Int4.x;
				}
				Vector3Int vector3Int5 = vector3Int4;
				if (num < 976513)
				{
					num = vector3Int4.y;
					if (vector3Int4.y < 0)
					{
						num = -vector3Int4.y;
					}
					if (num < 976513)
					{
						num = vector3Int4.z;
						if (vector3Int4.z < 0)
						{
							num = -vector3Int4.z;
						}
						if (num < 976513 && dAT_C.wheelsType != _WHEELS.Air && dAT_C.wheelsType != _WHEELS.Sea)
						{
							vector3Int4 = vector3Int5;
							Coprocessor.rotationMatrix.rt11 = (short)(DAT_A8.x >> 3);
							Coprocessor.rotationMatrix.rt12 = (short)(DAT_A8.x >> 3 >> 16);
							Coprocessor.rotationMatrix.rt22 = (short)(DAT_A8.y >> 3);
							Coprocessor.rotationMatrix.rt23 = (short)(DAT_A8.y >> 3 >> 16);
							Coprocessor.rotationMatrix.rt33 = (short)(DAT_A8.z >> 3);
							vector3Int3.x >>= 6;
							num = -32768;
							if (-32769 < vector3Int3.x)
							{
								num = 32767;
								if (vector3Int3.x < 32768)
								{
									num = vector3Int3.x;
								}
							}
							vector3Int3.y >>= 6;
							int num2 = -32768;
							if (-32769 < vector3Int3.y)
							{
								num2 = 32767;
								if (vector3Int3.y < 32768)
								{
									num2 = vector3Int3.y;
								}
							}
							vector3Int3.z >>= 6;
							int num3 = -32768;
							if (-32769 < vector3Int3.z)
							{
								num3 = 32767;
								if (vector3Int3.z < 32768)
								{
									num3 = vector3Int3.z;
								}
							}
							Coprocessor.accumulator.ir1 = (short)num;
							Coprocessor.accumulator.ir2 = (short)num2;
							Coprocessor.accumulator.ir3 = (short)num3;
							Coprocessor.ExecuteOP(12, lm: false);
							Vector3Int v = new Vector3Int(Coprocessor.mathsAccumulator.mac1, Coprocessor.mathsAccumulator.mac2, Coprocessor.mathsAccumulator.mac3);
							Vector3Int v2 = Utilities.FUN_24094(vTransform.rotation, vector3Int5);
							v2.x = -v2.x;
							v2.y = -v2.y;
							v2.z = -v2.z;
							dAT_C.FUN_2B370(v2, vector3Int);
							Vector3Int v3 = default(Vector3Int);
							v3.x = dAT_C.vTransform.rotation.V02;
							v3.y = dAT_C.vTransform.rotation.V12;
							v3.z = dAT_C.vTransform.rotation.V22;
							v3 = Utilities.FUN_24238(vTransform.rotation, v3);
							if (v3.z < 0)
							{
								dAT_C.physics2.Y += v3.x * -4;
							}
							uint num4 = 0u;
							if (vTransform.rotation.V11 < 0)
							{
								BufferedBinaryReader reader = vCollider.reader;
								uint num5 = 0u;
								do
								{
									Vector3Int v4 = default(Vector3Int);
									if (num5 == 0)
									{
										v4.x = reader.ReadInt32(4);
									}
									else
									{
										v4.x = reader.ReadInt32(16);
									}
									if ((num4 & 4) == 0)
									{
										v4.y = reader.ReadInt32(8);
									}
									else
									{
										v4.y = reader.ReadInt32(20);
									}
									if ((num4 & 2) == 0)
									{
										v4.z = reader.ReadInt32(12);
									}
									else
									{
										v4.z = reader.ReadInt32(24);
									}
									v4 = Utilities.FUN_24148(dAT_C.vTransform, v4);
									num2 = FUN_2CFBC(v4);
									if (0 < v4.y - num2)
									{
										num3 = -physics1.X;
										if (0 < physics1.X)
										{
											num3 += 3;
										}
										num3 >>= 2;
										Vector3Int vector3Int6 = default(Vector3Int);
										if (num3 < -2880)
										{
											vector3Int6.x = -2880;
										}
										else
										{
											vector3Int6.x = 2880;
											if (num3 < 2881)
											{
												vector3Int6.x = num3;
											}
										}
										num3 = -physics1.Z;
										if (0 < physics1.Z)
										{
											num3 += 3;
										}
										num3 >>= 2;
										if (num3 < -2880)
										{
											vector3Int6.z = -2880;
										}
										else
										{
											vector3Int6.z = 2880;
											if (num3 < 2881)
											{
												vector3Int6.z = num3;
											}
										}
										vector3Int6.y = -(v4.y - num2);
										if (0 < dAT_C.physics1.Y)
										{
											vector3Int6.y -= dAT_C.physics1.Y >> 2;
										}
										Coprocessor.rotationMatrix.rt11 = (short)(vTransform.position.x >> 3);
										Coprocessor.rotationMatrix.rt12 = (short)(vTransform.position.x >> 3 >> 16);
										Coprocessor.rotationMatrix.rt22 = (short)(vTransform.position.y >> 3);
										Coprocessor.rotationMatrix.rt23 = (short)(vTransform.position.y >> 3 >> 16);
										Coprocessor.rotationMatrix.rt33 = (short)(vTransform.position.z >> 3);
										Coprocessor.accumulator.ir1 = (short)(vector3Int6.x >> 3);
										Coprocessor.accumulator.ir2 = (short)(vector3Int6.y >> 3);
										Coprocessor.accumulator.ir3 = (short)(vector3Int6.z >> 3);
										Coprocessor.ExecuteOP(12, lm: false);
										vector3Int4.x += vector3Int6.x;
										vector3Int4.y += vector3Int6.y;
										vector3Int4.z += vector3Int6.z;
										num2 = Coprocessor.mathsAccumulator.mac1;
										v.x += num2;
										num2 = Coprocessor.mathsAccumulator.mac2;
										v.y += num2;
										num2 = Coprocessor.mathsAccumulator.mac3;
										v.z += num2;
									}
									num4++;
									num5 = (num4 & 1);
								}
								while ((int)num4 < 8);
								v = Utilities.FUN_2426C(dAT_C.vTransform.rotation, new Matrix2x4(v.x, v.y, v.z, 0));
								num = 0;
								do
								{
									Wheel wheel = DAT_C4[num];
									num3 = wheel.physics2.Z;
									wheel.screen.y = wheel.physics1.Y;
									num2 = num3;
									if (num3 < 0)
									{
										num2 = num3 + 63;
									}
									num3 -= num2 >> 6;
									wheel.physics2.Z = num3;
									if (wheel.physics2.Y != 0)
									{
										if (num3 < 0)
										{
											num3 += 4095;
										}
										num2 = (num3 >> 12) * wheel.physics2.Y;
										if (num2 < 0)
										{
											num2 += 524287;
										}
										wheel.vr.x -= num2 >> 19;
									}
									wheel.ApplyTransformation();
									num++;
								}
								while (num < 2);
							}
							else
							{
								Vector3Int normalVector = default(Vector3Int);
								Vector3Int v5 = default(Vector3Int);
								do
								{
									Wheel wheel2 = DAT_C4[num4];
									v5.x = wheel2.screen.x;
									v5.y = wheel2.screen.y + wheel2.physics2.X;
									v5.z = wheel2.screen.z;
									Vector3Int vector3Int7 = Utilities.FUN_24148(transform, v5);
									Vector3Int vector3Int8 = Utilities.FUN_24148(vTransform, v5);
									vector3Int8.y = FUN_2CFBC(vector3Int8, ref normalVector, out TileData normalTile);
									Vector3Int vector3Int9 = Utilities.FUN_24304(vTransform, vector3Int8);
									vector3Int9.y -= wheel2.physics2.X;
									if (vector3Int9.y < wheel2.physics1.Y)
									{
										uint num6 = (uint)(normalVector.x << 16 >> 16);
										uint num5 = (uint)physics1.X;
										long num7 = (long)num6 * (long)num5;
										uint num8 = (uint)(normalVector.y << 16 >> 16);
										uint y = (uint)physics1.Y;
										long num9 = (long)num8 * (long)y;
										uint num10 = (uint)num9;
										uint num11 = (uint)(normalVector.z << 16 >> 16);
										uint z = (uint)physics1.Z;
										long num12 = (long)num11 * (long)z;
										uint num13 = (uint)num12;
										int num14 = (int)num6 * ((int)num5 >> 31);
										int num15 = (int)((ulong)num12 >> 32) + (int)num11 * ((int)z >> 31) + (int)z * (normalVector.z << 16 >> 31);
										z = (uint)((int)num7 + (int)num10);
										num11 = z + num13;
										num2 = (int)((ulong)num7 >> 32) + num14 + (int)num5 * (normalVector.x << 16 >> 31) + (int)((ulong)num9 >> 32) + (int)num8 * ((int)y >> 31) + (int)y * (normalVector.y << 16 >> 31) + ((z < num10) ? 1 : 0) + num15 + ((num11 < num13) ? 1 : 0);
										num = FUN_1BC0(num11, num2, 0u, 0);
										if (num < 1)
										{
											num11 += 32767;
											num2 += ((num11 < 32767) ? 1 : 0);
										}
										num5 = (uint)((int)(num11 >> 15) | (num2 << 17));
										Vector3Int vector3Int10 = Utilities.FUN_24210(vTransform.rotation, normalVector);
										num = -vector3Int10.x * (int)num5;
										if (num < 0)
										{
											num += 4095;
										}
										num2 = 0;
										if (v5.x - vector3Int9.x < 0)
										{
											num2 = v5.x - vector3Int9.x;
										}
										num3 = -vector3Int10.z * (int)num5;
										if (num3 < 0)
										{
											num3 += 4095;
										}
										Vector3Int vector3Int6 = default(Vector3Int);
										vector3Int6.z = 0;
										if (v5.z - vector3Int9.z < 0)
										{
											vector3Int6.z = v5.z - vector3Int9.z;
										}
										vector3Int6.z = (num3 >> 12) - vector3Int6.z;
										num3 = wheel2.physics1.X;
										if (wheel2.physics1.X < vector3Int9.y)
										{
											num3 = vector3Int9.y;
										}
										if (wheel2.physics1.X < vector3Int9.y || wheel2.screen.y < vector3Int9.y)
										{
											vector3Int6.y = (vector3Int9.y - wheel2.screen.y) * wheel2.physics1.M7;
											if (vector3Int6.y < 0)
											{
												vector3Int6.y += 31;
											}
											vector3Int6.y >>= 5;
										}
										else
										{
											vector3Int6.y = (vector3Int9.y - wheel2.screen.y) * 16;
										}
										vector3Int6.y = (wheel2.physics1.Y - num3) * wheel2.physics1.M6 * 128 / vector3Int10.y + vector3Int6.y;
										wheel2.screen.y = vector3Int9.y;
										int num16;
										if (normalTile == null || normalTile.DAT_10[0] == 0)
										{
											num3 = vector3Int6.y * -2;
										}
										else
										{
											num16 = -vector3Int6.y * (256 - normalTile.DAT_10[0]);
											num3 = num16 >> 7;
											if (num16 < 0)
											{
												num3 = num16 + 127 >> 7;
											}
										}
										num16 = vector3Int7.x;
										if (vector3Int7.x < 0)
										{
											num16 = vector3Int7.x + 31;
										}
										vector3Int6.x = -(num16 >> 5);
										bool flag;
										if (num16 >> 5 < 1)
										{
											flag = (num3 < vector3Int6.x);
										}
										else
										{
											num3 = -num3;
											flag = (vector3Int6.x < num3);
										}
										if (flag)
										{
											vector3Int6.x = num3;
										}
										vector3Int6.x = (num >> 12) - num2 + vector3Int6.x;
										Coprocessor.rotationMatrix.rt11 = (short)(v5.x >> 3);
										Coprocessor.rotationMatrix.rt12 = (short)(v5.x >> 3 >> 16);
										Coprocessor.rotationMatrix.rt22 = (short)(v5.y >> 3);
										Coprocessor.rotationMatrix.rt23 = (short)(v5.y >> 3 >> 16);
										Coprocessor.rotationMatrix.rt33 = (short)(v5.z >> 3);
										num = vector3Int6.x >> 3;
										if (num < -32768)
										{
											num2 = -32768;
										}
										else
										{
											num2 = 32767;
											if (num < 32768)
											{
												num2 = num;
											}
										}
										num = vector3Int6.y >> 3;
										if (num < -32768)
										{
											num3 = -32768;
										}
										else
										{
											num3 = 32767;
											if (num < 32768)
											{
												num3 = num;
											}
										}
										num = vector3Int6.z >> 3;
										if (num < -32768)
										{
											num16 = -32768;
										}
										else
										{
											num16 = 32767;
											if (num < 32768)
											{
												num16 = num;
											}
										}
										Coprocessor.accumulator.ir1 = (short)num2;
										Coprocessor.accumulator.ir2 = (short)num3;
										Coprocessor.accumulator.ir3 = (short)num16;
										Coprocessor.ExecuteOP(12, lm: false);
										vector3Int4.x += vector3Int6.x;
										vector3Int4.y += vector3Int6.y;
										vector3Int4.z += vector3Int6.z;
										num = Coprocessor.mathsAccumulator.mac1;
										v.x += num;
										num = Coprocessor.mathsAccumulator.mac2;
										v.y += num;
										num = Coprocessor.mathsAccumulator.mac3;
										v.z += num;
									}
									else
									{
										wheel2.screen.y = wheel2.physics1.Y;
									}
									num = vector3Int7.z * wheel2.physics2.Y;
									wheel2.physics2.Z = vector3Int7.z;
									if (num < 0)
									{
										num += 524287;
									}
									wheel2.vr.x -= num >> 19;
									num4++;
									wheel2.ApplyTransformation();
								}
								while ((int)num4 < 2);
								vector3Int4 = Utilities.FUN_24094(vTransform.rotation, vector3Int4);
							}
							vector3Int4.y += GameManager.instance.gravityFactor;
							FUN_2AFF8(vector3Int4, v, noflip: true);
							num = physics2.X;
							int num17 = num;
							if (num < 0)
							{
								num17 = num + 31;
							}
							num2 = physics2.Y;
							physics2.X = num - (num17 >> 5);
							num17 = num2;
							if (num2 < 0)
							{
								num17 = num2 + 31;
							}
							num = physics2.Z;
							physics2.Y = num2 - (num17 >> 5);
							num17 = num;
							if (num < 0)
							{
								num17 = num + 31;
							}
							physics2.Z = num - (num17 >> 5);
							return;
						}
					}
				}
			}
			DAT_C0 = null;
			type = 4;
			id = 0;
			GameManager.instance.FUN_30CB0(this, 300);
			dAT_C.DAT_A6 -= DAT_A6;
		}
		else if ((dAT_C.flags & 0x4000) == 0)
		{
			DAT_C0 = null;
			type = 4;
			id = 0;
			GameManager.instance.FUN_30CB0(this, 300);
			dAT_C.DAT_A6 -= DAT_A6;
		}
		else
		{
			flags ^= 67108864u;
			Vector3Int v6 = default(Vector3Int);
			v6.x = DAT_B4.x - DAT_A8.x;
			v6.y = DAT_B4.y - DAT_A8.y;
			v6.z = DAT_B4.z - DAT_A8.z;
			vTransform = dAT_C.vTransform;
			vTransform.position = Utilities.FUN_24148(dAT_C.vTransform, v6);
			physics1.X = dAT_C.physics1.X;
			physics1.Y = dAT_C.physics1.Y;
			physics1.Z = dAT_C.physics1.Z;
			physics2.X = dAT_C.physics2.X;
			physics2.Y = dAT_C.physics2.Y;
			physics2.Z = dAT_C.physics2.Z;
			uint num4 = flags;
			if (((num4 ^ dAT_C.flags) & 0x4000000) != 0)
			{
				flags = (num4 ^ 0x4000000);
				num4 = flags;
			}
			if (((num4 ^ dAT_C.flags) & 2) != 0)
			{
				flags = (num4 ^ 2);
			}
		}
	}

	private int FUN_1BC0(uint param1, int param2, uint param3, int param4)
	{
		int result = 0;
		if (param4 <= param2)
		{
			result = 2;
			if (param2 <= param4)
			{
				if (param1 < param3)
				{
					result = 0;
				}
				else
				{
					result = 2;
					if (param1 <= param3)
					{
						result = 1;
					}
				}
			}
		}
		return result;
	}
}
