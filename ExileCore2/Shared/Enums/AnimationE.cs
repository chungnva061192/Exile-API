using System;

namespace ExileCore2.Shared.Enums
{
	// Token: 0x02000131 RID: 305
	public enum AnimationE
	{
		// Token: 0x0400048C RID: 1164
		Idle,
		// Token: 0x0400048D RID: 1165
		Melee,
		// Token: 0x0400048E RID: 1166
		MeleeWithStep,
		// Token: 0x0400048F RID: 1167
		OffMelee,
		// Token: 0x04000490 RID: 1168
		Run,
		// Token: 0x04000491 RID: 1169
		TakeHit,
		// Token: 0x04000492 RID: 1170
		Death,
		// Token: 0x04000493 RID: 1171
		Stomp,
		// Token: 0x04000494 RID: 1172
		Impale,
		// Token: 0x04000495 RID: 1173
		Cleave,
		// Token: 0x04000496 RID: 1174
		Charge,
		// Token: 0x04000497 RID: 1175
		ChargeEnd,
		// Token: 0x04000498 RID: 1176
		ChargeEndAlt,
		// Token: 0x04000499 RID: 1177
		GroundSlam,
		// Token: 0x0400049A RID: 1178
		LeapSlam,
		// Token: 0x0400049B RID: 1179
		LeapSlamNear,
		// Token: 0x0400049C RID: 1180
		DoubleStrike,
		// Token: 0x0400049D RID: 1181
		DoubleSlash,
		// Token: 0x0400049E RID: 1182
		DoubleSlashOffhand,
		// Token: 0x0400049F RID: 1183
		DoubleSlashMainhand,
		// Token: 0x040004A0 RID: 1184
		Sweep,
		// Token: 0x040004A1 RID: 1185
		SpellProjectile,
		// Token: 0x040004A2 RID: 1186
		SpellProjectileUpward,
		// Token: 0x040004A3 RID: 1187
		SpellAreaOfEffect,
		// Token: 0x040004A4 RID: 1188
		SpellBuff,
		// Token: 0x040004A5 RID: 1189
		SpellProjectileFire,
		// Token: 0x040004A6 RID: 1190
		SpellProjectileCold,
		// Token: 0x040004A7 RID: 1191
		SpellProjectileLightning,
		// Token: 0x040004A8 RID: 1192
		SpellProjectileChaos,
		// Token: 0x040004A9 RID: 1193
		SpellProjectileUpwardFire,
		// Token: 0x040004AA RID: 1194
		SpellProjectileUpwardCold,
		// Token: 0x040004AB RID: 1195
		SpellProjectileUpwardLightning,
		// Token: 0x040004AC RID: 1196
		SpellProjectileUpwardChaos,
		// Token: 0x040004AD RID: 1197
		SpellAreaOfEffectFire,
		// Token: 0x040004AE RID: 1198
		SpellAreaOfEffectCold,
		// Token: 0x040004AF RID: 1199
		SpellAreaOfEffectLightning,
		// Token: 0x040004B0 RID: 1200
		SpellAreaOfEffectChaos,
		// Token: 0x040004B1 RID: 1201
		SpellNova,
		// Token: 0x040004B2 RID: 1202
		SpellNovaFire,
		// Token: 0x040004B3 RID: 1203
		SpellNovaCold,
		// Token: 0x040004B4 RID: 1204
		SpellNovaLightning,
		// Token: 0x040004B5 RID: 1205
		SpellNovaChaos,
		// Token: 0x040004B6 RID: 1206
		SpellBuffFire,
		// Token: 0x040004B7 RID: 1207
		SpellBuffCold,
		// Token: 0x040004B8 RID: 1208
		SpellBuffLightning,
		// Token: 0x040004B9 RID: 1209
		SpellBuffChaos,
		// Token: 0x040004BA RID: 1210
		Throw,
		// Token: 0x040004BB RID: 1211
		Flurry,
		// Token: 0x040004BC RID: 1212
		LayTrap,
		// Token: 0x040004BD RID: 1213
		LayTotem,
		// Token: 0x040004BE RID: 1214
		LayBallista,
		// Token: 0x040004BF RID: 1215
		Emerge,
		// Token: 0x040004C0 RID: 1216
		DualStrike,
		// Token: 0x040004C1 RID: 1217
		Snipe,
		// Token: 0x040004C2 RID: 1218
		SnipeChannel,
		// Token: 0x040004C3 RID: 1219
		SnipeChannelEnd,
		// Token: 0x040004C4 RID: 1220
		Block,
		// Token: 0x040004C5 RID: 1221
		GlacialHammer,
		// Token: 0x040004C6 RID: 1222
		OffGlacialHammer,
		// Token: 0x040004C7 RID: 1223
		Emerge2,
		// Token: 0x040004C8 RID: 1224
		Emerge3,
		// Token: 0x040004C9 RID: 1225
		HeavyStrike,
		// Token: 0x040004CA RID: 1226
		OffHeavyStrike,
		// Token: 0x040004CB RID: 1227
		RainOfArrows,
		// Token: 0x040004CC RID: 1228
		RainOfArrowsAdditive,
		// Token: 0x040004CD RID: 1229
		BlastRain,
		// Token: 0x040004CE RID: 1230
		CloneShot,
		// Token: 0x040004CF RID: 1231
		Backstab,
		// Token: 0x040004D0 RID: 1232
		OffBackstab,
		// Token: 0x040004D1 RID: 1233
		Frenzy,
		// Token: 0x040004D2 RID: 1234
		OffFrenzy,
		// Token: 0x040004D3 RID: 1235
		PowerShot,
		// Token: 0x040004D4 RID: 1236
		OffPowerShot,
		// Token: 0x040004D5 RID: 1237
		Taunt,
		// Token: 0x040004D6 RID: 1238
		ChangeToStance1,
		// Token: 0x040004D7 RID: 1239
		ChangeToStance2,
		// Token: 0x040004D8 RID: 1240
		ChangeToStance3,
		// Token: 0x040004D9 RID: 1241
		Revive,
		// Token: 0x040004DA RID: 1242
		ShadowProjectiles,
		// Token: 0x040004DB RID: 1243
		HookOut,
		// Token: 0x040004DC RID: 1244
		HookIn,
		// Token: 0x040004DD RID: 1245
		HookInNear,
		// Token: 0x040004DE RID: 1246
		Dance,
		// Token: 0x040004DF RID: 1247
		Channel,
		// Token: 0x040004E0 RID: 1248
		AttackChannel,
		// Token: 0x040004E1 RID: 1249
		Cyclone,
		// Token: 0x040004E2 RID: 1250
		Hide,
		// Token: 0x040004E3 RID: 1251
		Hide2,
		// Token: 0x040004E4 RID: 1252
		Hide3,
		// Token: 0x040004E5 RID: 1253
		BarrageStart,
		// Token: 0x040004E6 RID: 1254
		BarrageFireMain,
		// Token: 0x040004E7 RID: 1255
		BarrageFireOff,
		// Token: 0x040004E8 RID: 1256
		BarrageActivate,
		// Token: 0x040004E9 RID: 1257
		BarrageActivateFlipped,
		// Token: 0x040004EA RID: 1258
		LongOpen,
		// Token: 0x040004EB RID: 1259
		Submerge,
		// Token: 0x040004EC RID: 1260
		Puncture,
		// Token: 0x040004ED RID: 1261
		OffPuncture,
		// Token: 0x040004EE RID: 1262
		DodgeLeft,
		// Token: 0x040004EF RID: 1263
		DodgeRight,
		// Token: 0x040004F0 RID: 1264
		DodgeForward,
		// Token: 0x040004F1 RID: 1265
		DodgeBack,
		// Token: 0x040004F2 RID: 1266
		SpellBuffFast,
		// Token: 0x040004F3 RID: 1267
		IncreasingPulses,
		// Token: 0x040004F4 RID: 1268
		Pant,
		// Token: 0x040004F5 RID: 1269
		CastFast,
		// Token: 0x040004F6 RID: 1270
		ChannelEnd,
		// Token: 0x040004F7 RID: 1271
		ChannelUnleash,
		// Token: 0x040004F8 RID: 1272
		ChannelAttackUnleash,
		// Token: 0x040004F9 RID: 1273
		SpectralThrow,
		// Token: 0x040004FA RID: 1274
		SpectralThrowOff,
		// Token: 0x040004FB RID: 1275
		Teleport,
		// Token: 0x040004FC RID: 1276
		Knockdown,
		// Token: 0x040004FD RID: 1277
		ThrowOff,
		// Token: 0x040004FE RID: 1278
		IdleRelaxed,
		// Token: 0x040004FF RID: 1279
		ChannelBow,
		// Token: 0x04000500 RID: 1280
		ChannelBowEnd,
		// Token: 0x04000501 RID: 1281
		RainOfSpores,
		// Token: 0x04000502 RID: 1282
		GroundSlamOffhand,
		// Token: 0x04000503 RID: 1283
		LeapSlamOffhand,
		// Token: 0x04000504 RID: 1284
		DoubleStrikeOffhand,
		// Token: 0x04000505 RID: 1285
		AttackChannelEnd,
		// Token: 0x04000506 RID: 1286
		ChangeToStance4,
		// Token: 0x04000507 RID: 1287
		ChainStrikeThrow,
		// Token: 0x04000508 RID: 1288
		SliceAndDice,
		// Token: 0x04000509 RID: 1289
		ChargeStart,
		// Token: 0x0400050A RID: 1290
		CoilingAssault,
		// Token: 0x0400050B RID: 1291
		AttackProjectileUpward,
		// Token: 0x0400050C RID: 1292
		ChannelBowUpwards,
		// Token: 0x0400050D RID: 1293
		ChannelBowUpwardsEnd,
		// Token: 0x0400050E RID: 1294
		DeathFromDegen,
		// Token: 0x0400050F RID: 1295
		DeathWhileMoving,
		// Token: 0x04000510 RID: 1296
		DeathForward,
		// Token: 0x04000511 RID: 1297
		DeathBackward,
		// Token: 0x04000512 RID: 1298
		DeathLeft,
		// Token: 0x04000513 RID: 1299
		DeathRight,
		// Token: 0x04000514 RID: 1300
		TakeHitForward,
		// Token: 0x04000515 RID: 1301
		TakeHitBackward,
		// Token: 0x04000516 RID: 1302
		TakeHitLeft,
		// Token: 0x04000517 RID: 1303
		TakeHitRight,
		// Token: 0x04000518 RID: 1304
		Warcry,
		// Token: 0x04000519 RID: 1305
		RunBackwards,
		// Token: 0x0400051A RID: 1306
		ChangeToStance5,
		// Token: 0x0400051B RID: 1307
		SummonMinion,
		// Token: 0x0400051C RID: 1308
		RunLeft,
		// Token: 0x0400051D RID: 1309
		RunRight,
		// Token: 0x0400051E RID: 1310
		ShieldBash,
		// Token: 0x0400051F RID: 1311
		ReviveFromDegen,
		// Token: 0x04000520 RID: 1312
		ReviveWhileMoving,
		// Token: 0x04000521 RID: 1313
		ReviveForward,
		// Token: 0x04000522 RID: 1314
		ReviveBackward,
		// Token: 0x04000523 RID: 1315
		ReviveLeft,
		// Token: 0x04000524 RID: 1316
		ReviveRight,
		// Token: 0x04000525 RID: 1317
		Fling,
		// Token: 0x04000526 RID: 1318
		ChargeEndLeft,
		// Token: 0x04000527 RID: 1319
		ChargeEndRight,
		// Token: 0x04000528 RID: 1320
		ChargeEnd180,
		// Token: 0x04000529 RID: 1321
		WhirlwindSpear,
		// Token: 0x0400052A RID: 1322
		SpearCleaveRight,
		// Token: 0x0400052B RID: 1323
		SpearCleaveLeft,
		// Token: 0x0400052C RID: 1324
		GuardedAssaultChannel,
		// Token: 0x0400052D RID: 1325
		GuardedAssaultChannelEnd,
		// Token: 0x0400052E RID: 1326
		SpearWall,
		// Token: 0x0400052F RID: 1327
		SpearWallMoving,
		// Token: 0x04000530 RID: 1328
		SpearDoubleThrow,
		// Token: 0x04000531 RID: 1329
		FlinchForward,
		// Token: 0x04000532 RID: 1330
		FlinchBackward,
		// Token: 0x04000533 RID: 1331
		FlinchLeft,
		// Token: 0x04000534 RID: 1332
		FlinchRight,
		// Token: 0x04000535 RID: 1333
		ChangeAmmoDefault,
		// Token: 0x04000536 RID: 1334
		ChangeAmmoDefaultMoving,
		// Token: 0x04000537 RID: 1335
		TreeToTreeJumpLeft,
		// Token: 0x04000538 RID: 1336
		TreeToTreeJumpRight,
		// Token: 0x04000539 RID: 1337
		TreeToVineJumpLeft,
		// Token: 0x0400053A RID: 1338
		TreeToVineJumpRight,
		// Token: 0x0400053B RID: 1339
		VineToTreeJump,
		// Token: 0x0400053C RID: 1340
		VineToVineJump,
		// Token: 0x0400053D RID: 1341
		TreeToGroundJumpLeft,
		// Token: 0x0400053E RID: 1342
		TreeToGroundJumpRight,
		// Token: 0x0400053F RID: 1343
		VineToGroundJumpLeft,
		// Token: 0x04000540 RID: 1344
		VineToGroundJumpRight,
		// Token: 0x04000541 RID: 1345
		InteractPlaceGemstone,
		// Token: 0x04000542 RID: 1346
		Chop,
		// Token: 0x04000543 RID: 1347
		Slash,
		// Token: 0x04000544 RID: 1348
		Sunder,
		// Token: 0x04000545 RID: 1349
		FixedRun,
		// Token: 0x04000546 RID: 1350
		WhirlingAssault,
		// Token: 0x04000547 RID: 1351
		LightningStrike,
		// Token: 0x04000548 RID: 1352
		DoubleSlam,
		// Token: 0x04000549 RID: 1353
		WeaponSpell,
		// Token: 0x0400054A RID: 1354
		EscapeShot,
		// Token: 0x0400054B RID: 1355
		FlaskDash,
		// Token: 0x0400054C RID: 1356
		InteractPullLever,
		// Token: 0x0400054D RID: 1357
		SpellNovaEpic,
		// Token: 0x0400054E RID: 1358
		SpellNovaEpicFire,
		// Token: 0x0400054F RID: 1359
		SpellNovaEpicCold,
		// Token: 0x04000550 RID: 1360
		SpellNovaEpicLightning,
		// Token: 0x04000551 RID: 1361
		SpellNovaEpicChaos,
		// Token: 0x04000552 RID: 1362
		SpreadShot,
		// Token: 0x04000553 RID: 1363
		GaleStrike,
		// Token: 0x04000554 RID: 1364
		BladeDance,
		// Token: 0x04000555 RID: 1365
		ClawRake,
		// Token: 0x04000556 RID: 1366
		DoubleSlamMoving,
		// Token: 0x04000557 RID: 1367
		DoubleSlamMovingNear,
		// Token: 0x04000558 RID: 1368
		LeapSlamMoving,
		// Token: 0x04000559 RID: 1369
		LeapSlamMovingNear,
		// Token: 0x0400055A RID: 1370
		GlacialStrikeChannel,
		// Token: 0x0400055B RID: 1371
		GlacialStrikeChannelEnd,
		// Token: 0x0400055C RID: 1372
		RingOfIce,
		// Token: 0x0400055D RID: 1373
		RingOfIceStatueWindup,
		// Token: 0x0400055E RID: 1374
		RingOfIceStatueAttack,
		// Token: 0x0400055F RID: 1375
		Execute,
		// Token: 0x04000560 RID: 1376
		LeapingChop,
		// Token: 0x04000561 RID: 1377
		WhirlingSlash,
		// Token: 0x04000562 RID: 1378
		RaisedChop,
		// Token: 0x04000563 RID: 1379
		HeavyCleave,
		// Token: 0x04000564 RID: 1380
		ThrowNear,
		// Token: 0x04000565 RID: 1381
		ChannelUpward,
		// Token: 0x04000566 RID: 1382
		ChannelUpwardEnd,
		// Token: 0x04000567 RID: 1383
		ChannelProjectile,
		// Token: 0x04000568 RID: 1384
		ChannelProjectileEnd,
		// Token: 0x04000569 RID: 1385
		HeavyStun,
		// Token: 0x0400056A RID: 1386
		HeavyStunBack,
		// Token: 0x0400056B RID: 1387
		HeavyStunForward,
		// Token: 0x0400056C RID: 1388
		HeavyStunDeath,
		// Token: 0x0400056D RID: 1389
		HeavyStunBackDeath,
		// Token: 0x0400056E RID: 1390
		HeavyStunForwardDeath,
		// Token: 0x0400056F RID: 1391
		ShieldBuff,
		// Token: 0x04000570 RID: 1392
		FlickerStrike,
		// Token: 0x04000571 RID: 1393
		FlickerStrikeFirst,
		// Token: 0x04000572 RID: 1394
		PalmStrike,
		// Token: 0x04000573 RID: 1395
		Vortex,
		// Token: 0x04000574 RID: 1396
		BackflipKnifeThrow,
		// Token: 0x04000575 RID: 1397
		WeaponBuff,
		// Token: 0x04000576 RID: 1398
		WeaponAreaOfEffect,
		// Token: 0x04000577 RID: 1399
		BurstShot,
		// Token: 0x04000578 RID: 1400
		SpellAoeEpic,
		// Token: 0x04000579 RID: 1401
		SpellAoeEpicBackflip,
		// Token: 0x0400057A RID: 1402
		SpellAoeEpicFire,
		// Token: 0x0400057B RID: 1403
		SpellAoeEpicCold,
		// Token: 0x0400057C RID: 1404
		SpellAoeEpicLightning,
		// Token: 0x0400057D RID: 1405
		SpellAoeEpicChaos,
		// Token: 0x0400057E RID: 1406
		BladeNova,
		// Token: 0x0400057F RID: 1407
		SpellWall,
		// Token: 0x04000580 RID: 1408
		SunderMoving,
		// Token: 0x04000581 RID: 1409
		GroundSlamMoving,
		// Token: 0x04000582 RID: 1410
		LightningStrikeStationary,
		// Token: 0x04000583 RID: 1411
		LightningStrikeMoving,
		// Token: 0x04000584 RID: 1412
		WeaponSwap,
		// Token: 0x04000585 RID: 1413
		Meditate,
		// Token: 0x04000586 RID: 1414
		MeditateEnd,
		// Token: 0x04000587 RID: 1415
		SpellChannelEpicEnd,
		// Token: 0x04000588 RID: 1416
		Electrocute,
		// Token: 0x04000589 RID: 1417
		PestilentSlash,
		// Token: 0x0400058A RID: 1418
		ViperStrike,
		// Token: 0x0400058B RID: 1419
		DodgeRoll,
		// Token: 0x0400058C RID: 1420
		IcePath,
		// Token: 0x0400058D RID: 1421
		InteractPullLeverWallMounted,
		// Token: 0x0400058E RID: 1422
		LeapingCatch,
		// Token: 0x0400058F RID: 1423
		ShadowThiefSlash,
		// Token: 0x04000590 RID: 1424
		PlungingBlade,
		// Token: 0x04000591 RID: 1425
		PlungingBladeMoving,
		// Token: 0x04000592 RID: 1426
		ShadowDash,
		// Token: 0x04000593 RID: 1427
		ShadowDashStationary,
		// Token: 0x04000594 RID: 1428
		BearMaul,
		// Token: 0x04000595 RID: 1429
		BearMaulMoving,
		// Token: 0x04000596 RID: 1430
		ShadowThiefSlashClone,
		// Token: 0x04000597 RID: 1431
		ChannelVolcanoEnd,
		// Token: 0x04000598 RID: 1432
		ChannelVolcano,
		// Token: 0x04000599 RID: 1433
		ChannelStart,
		// Token: 0x0400059A RID: 1434
		SpiralVolley,
		// Token: 0x0400059B RID: 1435
		SpiralVolleyEmpowered,
		// Token: 0x0400059C RID: 1436
		HeatSeeking,
		// Token: 0x0400059D RID: 1437
		HeatSeekingEnd,
		// Token: 0x0400059E RID: 1438
		HeatSeekingStart,
		// Token: 0x0400059F RID: 1439
		LeapAttack,
		// Token: 0x040005A0 RID: 1440
		LeapAttackFar,
		// Token: 0x040005A1 RID: 1441
		SummonMinionLightning,
		// Token: 0x040005A2 RID: 1442
		SummonMinionCold,
		// Token: 0x040005A3 RID: 1443
		SummonMinionFire,
		// Token: 0x040005A4 RID: 1444
		SummonMinionChaos,
		// Token: 0x040005A5 RID: 1445
		SpellWallLightning,
		// Token: 0x040005A6 RID: 1446
		SpellWallCold,
		// Token: 0x040005A7 RID: 1447
		SpellWallFire,
		// Token: 0x040005A8 RID: 1448
		SpellWallChaos,
		// Token: 0x040005A9 RID: 1449
		Spark,
		// Token: 0x040005AA RID: 1450
		SparkAdditive,
		// Token: 0x040005AB RID: 1451
		Arc,
		// Token: 0x040005AC RID: 1452
		IceNova,
		// Token: 0x040005AD RID: 1453
		WhirlingAssaultMoving,
		// Token: 0x040005AE RID: 1454
		RampageStart,
		// Token: 0x040005AF RID: 1455
		RampageLoop,
		// Token: 0x040005B0 RID: 1456
		RampageEnd,
		// Token: 0x040005B1 RID: 1457
		FrostBomb,
		// Token: 0x040005B2 RID: 1458
		ComboAttack,
		// Token: 0x040005B3 RID: 1459
		ComboAttackMoving,
		// Token: 0x040005B4 RID: 1460
		LightningStorm,
		// Token: 0x040005B5 RID: 1461
		MinionSurplusDeath,
		// Token: 0x040005B6 RID: 1462
		MinionDiedAfterTime,
		// Token: 0x040005B7 RID: 1463
		UnleashBuff,
		// Token: 0x040005B8 RID: 1464
		JumpOffBoat,
		// Token: 0x040005B9 RID: 1465
		ShapeshiftBearToHuman,
		// Token: 0x040005BA RID: 1466
		ShapeshiftBearMaul,
		// Token: 0x040005BB RID: 1467
		ShapeshiftBearRampage,
		// Token: 0x040005BC RID: 1468
		ShapeshiftBearSlam,
		// Token: 0x040005BD RID: 1469
		ShapeshiftBearWarcry,
		// Token: 0x040005BE RID: 1470
		ShapeshiftWolfToHuman,
		// Token: 0x040005BF RID: 1471
		ShapeshiftWolfHowl,
		// Token: 0x040005C0 RID: 1472
		ShapeshiftWolfLeapAttack,
		// Token: 0x040005C1 RID: 1473
		LookLeft,
		// Token: 0x040005C2 RID: 1474
		LookRight,
		// Token: 0x040005C3 RID: 1475
		ChannelVolcanoStart,
		// Token: 0x040005C4 RID: 1476
		Tornado,
		// Token: 0x040005C5 RID: 1477
		SummonWolf,
		// Token: 0x040005C6 RID: 1478
		LightningBolt,
		// Token: 0x040005C7 RID: 1479
		LightningBoltAdditive,
		// Token: 0x040005C8 RID: 1480
		InteractPlaceGemstoneJungleOutskirts,
		// Token: 0x040005C9 RID: 1481
		InteractPlaceGemstoneGenerator,
		// Token: 0x040005CA RID: 1482
		WhirlwindSpearMoving,
		// Token: 0x040005CB RID: 1483
		FrostWall,
		// Token: 0x040005CC RID: 1484
		Comet,
		// Token: 0x040005CD RID: 1485
		Engage,
		// Token: 0x040005CE RID: 1486
		EngageFar,
		// Token: 0x040005CF RID: 1487
		EngageFarMoving,
		// Token: 0x040005D0 RID: 1488
		BearSlam,
		// Token: 0x040005D1 RID: 1489
		CometStationary,
		// Token: 0x040005D2 RID: 1490
		ManaTempest,
		// Token: 0x040005D3 RID: 1491
		TownPortal,
		// Token: 0x040005D4 RID: 1492
		InteractStabPrison,
		// Token: 0x040005D5 RID: 1493
		ArcticArmour,
		// Token: 0x040005D6 RID: 1494
		Hex,
		// Token: 0x040005D7 RID: 1495
		Bladestorm,
		// Token: 0x040005D8 RID: 1496
		PhalanxBash,
		// Token: 0x040005D9 RID: 1497
		AdvancingWhirlLoop,
		// Token: 0x040005DA RID: 1498
		AdvancingWhirlEnd,
		// Token: 0x040005DB RID: 1499
		PowerShotDefault,
		// Token: 0x040005DC RID: 1500
		PowerShotPiercing,
		// Token: 0x040005DD RID: 1501
		PowerShotFire,
		// Token: 0x040005DE RID: 1502
		PowerShotLightning,
		// Token: 0x040005DF RID: 1503
		PowerShotIce,
		// Token: 0x040005E0 RID: 1504
		BurstShotDefault,
		// Token: 0x040005E1 RID: 1505
		BurstShotPiercing,
		// Token: 0x040005E2 RID: 1506
		BurstShotFire,
		// Token: 0x040005E3 RID: 1507
		BurstShotLightning,
		// Token: 0x040005E4 RID: 1508
		BurstShotIce,
		// Token: 0x040005E5 RID: 1509
		RapidShotDefault,
		// Token: 0x040005E6 RID: 1510
		RapidShotPiercing,
		// Token: 0x040005E7 RID: 1511
		RapidShotFire,
		// Token: 0x040005E8 RID: 1512
		RapidShotLightning,
		// Token: 0x040005E9 RID: 1513
		RapidShotIce,
		// Token: 0x040005EA RID: 1514
		SiegeCascadeDefault,
		// Token: 0x040005EB RID: 1515
		SiegeCascadePiercing,
		// Token: 0x040005EC RID: 1516
		SiegeCascadeFire,
		// Token: 0x040005ED RID: 1517
		SiegeCascadeLightning,
		// Token: 0x040005EE RID: 1518
		SiegeCascadeIce,
		// Token: 0x040005EF RID: 1519
		ChangeAmmoPiercing,
		// Token: 0x040005F0 RID: 1520
		ChangeAmmoFire,
		// Token: 0x040005F1 RID: 1521
		ChangeAmmoLightning,
		// Token: 0x040005F2 RID: 1522
		ChangeAmmoIce,
		// Token: 0x040005F3 RID: 1523
		ChangeAmmoPiercingMoving,
		// Token: 0x040005F4 RID: 1524
		ChangeAmmoFireMoving,
		// Token: 0x040005F5 RID: 1525
		ChangeAmmoLightningMoving,
		// Token: 0x040005F6 RID: 1526
		ChangeAmmoIceMoving,
		// Token: 0x040005F7 RID: 1527
		PowerShotLightningChannelEnd,
		// Token: 0x040005F8 RID: 1528
		RaiseSpectre,
		// Token: 0x040005F9 RID: 1529
		BindSpectre,
		// Token: 0x040005FA RID: 1530
		AimUp,
		// Token: 0x040005FB RID: 1531
		AimDown,
		// Token: 0x040005FC RID: 1532
		ExplosiveGrenade,
		// Token: 0x040005FD RID: 1533
		FlashGrenade,
		// Token: 0x040005FE RID: 1534
		ToxicGrenade,
		// Token: 0x040005FF RID: 1535
		OilGrenade,
		// Token: 0x04000600 RID: 1536
		ShockGrenade,
		// Token: 0x04000601 RID: 1537
		RaiseZombie,
		// Token: 0x04000602 RID: 1538
		SummonSkeletonsEnd,
		// Token: 0x04000603 RID: 1539
		RapidShotChargeFire,
		// Token: 0x04000604 RID: 1540
		DodgeRollBack,
		// Token: 0x04000605 RID: 1541
		RollingMagma,
		// Token: 0x04000606 RID: 1542
		Firestorm,
		// Token: 0x04000607 RID: 1543
		CommandMinion,
		// Token: 0x04000608 RID: 1544
		SummonOffering,
		// Token: 0x04000609 RID: 1545
		TempestFlurry,
		// Token: 0x0400060A RID: 1546
		TempestFlurryMoving,
		// Token: 0x0400060B RID: 1547
		CommandMinionChannel,
		// Token: 0x0400060C RID: 1548
		CommandMinionChannelEnd,
		// Token: 0x0400060D RID: 1549
		ChargedStrike,
		// Token: 0x0400060E RID: 1550
		ChargedStrikeStationary,
		// Token: 0x0400060F RID: 1551
		ChargedStrikeFlourish,
		// Token: 0x04000610 RID: 1552
		TempestBellSlam,
		// Token: 0x04000611 RID: 1553
		TempestBellSlamStationary,
		// Token: 0x04000612 RID: 1554
		RapidAssault,
		// Token: 0x04000613 RID: 1555
		IceSpear,
		// Token: 0x04000614 RID: 1556
		StormSpear,
		// Token: 0x04000615 RID: 1557
		FreezingBackflip,
		// Token: 0x04000616 RID: 1558
		GlacialCascade,
		// Token: 0x04000617 RID: 1559
		ChargeStaff,
		// Token: 0x04000618 RID: 1560
		Chaosbolt,
		// Token: 0x04000619 RID: 1561
		Frostbolt,
		// Token: 0x0400061A RID: 1562
		BoneSpike,
		// Token: 0x0400061B RID: 1563
		BoneSpikeEnd,
		// Token: 0x0400061C RID: 1564
		Contagion,
		// Token: 0x0400061D RID: 1565
		EssenceDrain,
		// Token: 0x0400061E RID: 1566
		OrbOfIce,
		// Token: 0x0400061F RID: 1567
		Hexblast,
		// Token: 0x04000620 RID: 1568
		ForbiddenRite,
		// Token: 0x04000621 RID: 1569
		ForbiddenRiteEnd,
		// Token: 0x04000622 RID: 1570
		ConsumeCorpse,
		// Token: 0x04000623 RID: 1571
		WindPalm,
		// Token: 0x04000624 RID: 1572
		BoneCone,
		// Token: 0x04000625 RID: 1573
		FixedRunLayerBase,
		// Token: 0x04000626 RID: 1574
		FixedRunLayerNoTwist,
		// Token: 0x04000627 RID: 1575
		IdleLayerBase,
		// Token: 0x04000628 RID: 1576
		IdleLayerBaseStatic,
		// Token: 0x04000629 RID: 1577
		MeleeAdditive,
		// Token: 0x0400062A RID: 1578
		DetonatingArrow,
		// Token: 0x0400062B RID: 1579
		DetonatingArrowStart,
		// Token: 0x0400062C RID: 1580
		DetonatingArrowEnd,
		// Token: 0x0400062D RID: 1581
		LightningArrow,
		// Token: 0x0400062E RID: 1582
		ShockingArrow,
		// Token: 0x0400062F RID: 1583
		RipwireArrow,
		// Token: 0x04000630 RID: 1584
		PoisonArrow,
		// Token: 0x04000631 RID: 1585
		StormRain,
		// Token: 0x04000632 RID: 1586
		Mark,
		// Token: 0x04000633 RID: 1587
		SnipersMark,
		// Token: 0x04000634 RID: 1588
		SnipersMarkFlipped,
		// Token: 0x04000635 RID: 1589
		FixedRunLayerBaseSwitched,
		// Token: 0x04000636 RID: 1590
		FixedRunLayerNoTwistSwitched,
		// Token: 0x04000637 RID: 1591
		FixedRunLayerBaseFrontal,
		// Token: 0x04000638 RID: 1592
		FixedRunLayerNoTwistFrontal,
		// Token: 0x04000639 RID: 1593
		ElectrocutingArrow,
		// Token: 0x0400063A RID: 1594
		PerfectStrike,
		// Token: 0x0400063B RID: 1595
		PerfectStrikeEnd,
		// Token: 0x0400063C RID: 1596
		PerfectStrikePerfectEnd,
		// Token: 0x0400063D RID: 1597
		SolarOrb,
		// Token: 0x0400063E RID: 1598
		GreaterFireball,
		// Token: 0x0400063F RID: 1599
		Shatter,
		// Token: 0x04000640 RID: 1600
		LightningWarp,
		// Token: 0x04000641 RID: 1601
		ChannelFlameblast,
		// Token: 0x04000642 RID: 1602
		ChannelFlameblastEnd,
		// Token: 0x04000643 RID: 1603
		Flamewall,
		// Token: 0x04000644 RID: 1604
		FrozenOrb,
		// Token: 0x04000645 RID: 1605
		OrbOfStorms,
		// Token: 0x04000646 RID: 1606
		ShockingRemnants,
		// Token: 0x04000647 RID: 1607
		LightningConduit,
		// Token: 0x04000648 RID: 1608
		LightningConduitStationary,
		// Token: 0x04000649 RID: 1609
		Boneshatter,
		// Token: 0x0400064A RID: 1610
		ActiveBlockChannel,
		// Token: 0x0400064B RID: 1611
		ActiveBlockEnd,
		// Token: 0x0400064C RID: 1612
		ActiveBlockChannelMoving,
		// Token: 0x0400064D RID: 1613
		ActiveBlockEndMoving,
		// Token: 0x0400064E RID: 1614
		GreaterFrostbolt,
		// Token: 0x0400064F RID: 1615
		PlagueNova,
		// Token: 0x04000650 RID: 1616
		ShieldDrum,
		// Token: 0x04000651 RID: 1617
		ShieldDrumEnd,
		// Token: 0x04000652 RID: 1618
		BaronSwordImpaledStart,
		// Token: 0x04000653 RID: 1619
		BaronSwordImpaledLoop,
		// Token: 0x04000654 RID: 1620
		BaronSwordImpaledEnd,
		// Token: 0x04000655 RID: 1621
		PlaceTotemStomp,
		// Token: 0x04000656 RID: 1622
		FlameblastOrbStart,
		// Token: 0x04000657 RID: 1623
		FlameblastOrb,
		// Token: 0x04000658 RID: 1624
		FlameblastOrbEnd,
		// Token: 0x04000659 RID: 1625
		VineArrow,
		// Token: 0x0400065A RID: 1626
		SnipeChannelEndPerfect,
		// Token: 0x0400065B RID: 1627
		FreezingShards,
		// Token: 0x0400065C RID: 1628
		VineRain,
		// Token: 0x0400065D RID: 1629
		BoneshatterMoving,
		// Token: 0x0400065E RID: 1630
		PowerSiphon,
		// Token: 0x0400065F RID: 1631
		IdleLayerBaseSwitched,
		// Token: 0x04000660 RID: 1632
		IdleLayerBaseStaticSwitched,
		// Token: 0x04000661 RID: 1633
		VineArrowStationary,
		// Token: 0x04000662 RID: 1634
		Mount,
		// Token: 0x04000663 RID: 1635
		Dismount,
		// Token: 0x04000664 RID: 1636
		MountedLayerIdleSync,
		// Token: 0x04000665 RID: 1637
		MountedLayerRunSync,
		// Token: 0x04000666 RID: 1638
		FixedIdle,
		// Token: 0x04000667 RID: 1639
		FixedIdleLayerBase,
		// Token: 0x04000668 RID: 1640
		VolcanicFissure,
		// Token: 0x04000669 RID: 1641
		AssassinsMark,
		// Token: 0x0400066A RID: 1642
		EssenceDrainAdditive,
		// Token: 0x0400066B RID: 1643
		BoneRing,
		// Token: 0x0400066C RID: 1644
		DetonateDead,
		// Token: 0x0400066D RID: 1645
		SummonRagingSpirit,
		// Token: 0x0400066E RID: 1646
		Vulnerability,
		// Token: 0x0400066F RID: 1647
		Enfeeble,
		// Token: 0x04000670 RID: 1648
		Despair,
		// Token: 0x04000671 RID: 1649
		InteractUseHornOfTheVastiri,
		// Token: 0x04000672 RID: 1650
		KnockdownStart,
		// Token: 0x04000673 RID: 1651
		KnockdownLoop,
		// Token: 0x04000674 RID: 1652
		KnockdownEnd,
		// Token: 0x04000675 RID: 1653
		CorpseCloud,
		// Token: 0x04000676 RID: 1654
		CommandMinionPoint,
		// Token: 0x04000677 RID: 1655
		FlickerStrikeFirstMoving,
		// Token: 0x04000678 RID: 1656
		DoryaniHumanBossCrystalTossLeft,
		// Token: 0x04000679 RID: 1657
		DoryaniHumanBossCrystalTossRight,
		// Token: 0x0400067A RID: 1658
		DoryaniHumanBossFlamethrower,
		// Token: 0x0400067B RID: 1659
		DoryaniHumanBossLightningTendrils,
		// Token: 0x0400067C RID: 1660
		Spearstorm,
		// Token: 0x0400067D RID: 1661
		DoryaniHumanBossLightningZap,
		// Token: 0x0400067E RID: 1662
		RaiseZombieAdditive,
		// Token: 0x0400067F RID: 1663
		RemoteSpearMine,
		// Token: 0x04000680 RID: 1664
		DoryaniHumanBossDodgeLeft,
		// Token: 0x04000681 RID: 1665
		DoryaniHumanBossDodgeRight,
		// Token: 0x04000682 RID: 1666
		DoryaniHumanBossFireball,
		// Token: 0x04000683 RID: 1667
		DoryaniHumanBossFlameblastSelf,
		// Token: 0x04000684 RID: 1668
		DoryaniHumanBossFlameblastTargeted,
		// Token: 0x04000685 RID: 1669
		DoryaniHumanBossSolarOrb,
		// Token: 0x04000686 RID: 1670
		DoryaniHumanBossSoulCoresArena,
		// Token: 0x04000687 RID: 1671
		DoryaniHumanBossSoulCoresLeft,
		// Token: 0x04000688 RID: 1672
		DoryaniHumanBossSoulCoresRight,
		// Token: 0x04000689 RID: 1673
		SuperchargedSlam,
		// Token: 0x0400068A RID: 1674
		SuperchargedSlamEnd,
		// Token: 0x0400068B RID: 1675
		FloatIdle,
		// Token: 0x0400068C RID: 1676
		FixedFloat,
		// Token: 0x0400068D RID: 1677
		FloatRun,
		// Token: 0x0400068E RID: 1678
		SpearLightningWarp,
		// Token: 0x0400068F RID: 1679
		SpearLightningWarpNear,
		// Token: 0x04000690 RID: 1680
		SpearWindVortex,
		// Token: 0x04000691 RID: 1681
		Earthquake,
		// Token: 0x04000692 RID: 1682
		RitualOfPower,
		// Token: 0x04000693 RID: 1683
		SpellProjectileAimUp,
		// Token: 0x04000694 RID: 1684
		SpellProjectileAimDown,
		// Token: 0x04000695 RID: 1685
		CartIdle,
		// Token: 0x04000696 RID: 1686
		CartJump,
		// Token: 0x04000697 RID: 1687
		CommandSkeletalReavers,
		// Token: 0x04000698 RID: 1688
		CommandSkeletalSniper,
		// Token: 0x04000699 RID: 1689
		CommandSkeletalFrostMage,
		// Token: 0x0400069A RID: 1690
		CommandSkeletalStormMage,
		// Token: 0x0400069B RID: 1691
		CommandSkeletalArsonist,
		// Token: 0x0400069C RID: 1692
		PlaceTotemSummon,
		// Token: 0x0400069D RID: 1693
		WarcryAdditive,
		// Token: 0x0400069E RID: 1694
		Flammability,
		// Token: 0x0400069F RID: 1695
		Frostbite,
		// Token: 0x040006A0 RID: 1696
		Conductivity,
		// Token: 0x040006A1 RID: 1697
		TeleportForward,
		// Token: 0x040006A2 RID: 1698
		TeleportBackward,
		// Token: 0x040006A3 RID: 1699
		TeleportLeft,
		// Token: 0x040006A4 RID: 1700
		TeleportRight,
		// Token: 0x040006A5 RID: 1701
		BoneBlast,
		// Token: 0x040006A6 RID: 1702
		ManaDrain,
		// Token: 0x040006A7 RID: 1703
		VolatileDead,
		// Token: 0x040006A8 RID: 1704
		GalvanicField,
		// Token: 0x040006A9 RID: 1705
		Exsanguinate,
		// Token: 0x040006AA RID: 1706
		ArcticBurst,
		// Token: 0x040006AB RID: 1707
		EmpowerWand,
		// Token: 0x040006AC RID: 1708
		Wither,
		// Token: 0x040006AD RID: 1709
		WitherStart,
		// Token: 0x040006AE RID: 1710
		WitherEnd,
		// Token: 0x040006AF RID: 1711
		Spellslinger,
		// Token: 0x040006B0 RID: 1712
		LivingBomb,
		// Token: 0x040006B1 RID: 1713
		SigilOfPower,
		// Token: 0x040006B2 RID: 1714
		Soulrend,
		// Token: 0x040006B3 RID: 1715
		Reap,
		// Token: 0x040006B4 RID: 1716
		IceStorm,
		// Token: 0x040006B5 RID: 1717
		ShockNova,
		// Token: 0x040006B6 RID: 1718
		ConsecratedGround,
		// Token: 0x040006B7 RID: 1719
		DarkPact,
		// Token: 0x040006B8 RID: 1720
		DarkPactSelf,
		// Token: 0x040006B9 RID: 1721
		SpinningInferno,
		// Token: 0x040006BA RID: 1722
		SpinningInfernoMoving,
		// Token: 0x040006BB RID: 1723
		MoltenBlast,
		// Token: 0x040006BC RID: 1724
		AncestralCry,
		// Token: 0x040006BD RID: 1725
		ShieldingCry,
		// Token: 0x040006BE RID: 1726
		HammerOfTheGods,
		// Token: 0x040006BF RID: 1727
		ShieldBarricade,
		// Token: 0x040006C0 RID: 1728
		StampedeStart,
		// Token: 0x040006C1 RID: 1729
		StampedeStartMoving,
		// Token: 0x040006C2 RID: 1730
		Stampede,
		// Token: 0x040006C3 RID: 1731
		StampedeEnd,
		// Token: 0x040006C4 RID: 1732
		BallLightning,
		// Token: 0x040006C5 RID: 1733
		IncinerateStart,
		// Token: 0x040006C6 RID: 1734
		Incinerate,
		// Token: 0x040006C7 RID: 1735
		IncinerateEnd,
		// Token: 0x040006C8 RID: 1736
		EyeOfWinter,
		// Token: 0x040006C9 RID: 1737
		SeismicCry,
		// Token: 0x040006CA RID: 1738
		InfernalCry,
		// Token: 0x040006CB RID: 1739
		InteractPlaceTempleDoorKey,
		// Token: 0x040006CC RID: 1740
		ArmourBreaker,
		// Token: 0x040006CD RID: 1741
		ArmourBreakerMoving,
		// Token: 0x040006CE RID: 1742
		ArmourBreakerShort,
		// Token: 0x040006CF RID: 1743
		InteractWaterwaysFinalLever,
		// Token: 0x040006D0 RID: 1744
		InteractSacrificialHeartPlacement,
		// Token: 0x040006D1 RID: 1745
		InteractSacrificialHeartDestroy,
		// Token: 0x040006D2 RID: 1746
		MoltenSlam,
		// Token: 0x040006D3 RID: 1747
		FreezingMark,
		// Token: 0x040006D4 RID: 1748
		FreezingMarkFlipped,
		// Token: 0x040006D5 RID: 1749
		ToxicDomain,
		// Token: 0x040006D6 RID: 1750
		TornadoShot,
		// Token: 0x040006D7 RID: 1751
		LightningWall,
		// Token: 0x040006D8 RID: 1752
		IceShot,
		// Token: 0x040006D9 RID: 1753
		TrickShot,
		// Token: 0x040006DA RID: 1754
		MagneticSalvo,
		// Token: 0x040006DB RID: 1755
		FreezingSalvo,
		// Token: 0x040006DC RID: 1756
		ChangeAmmoAfterFireDefault,
		// Token: 0x040006DD RID: 1757
		ChangeAmmoAfterFireDefaultMoving,
		// Token: 0x040006DE RID: 1758
		ChangeAmmoAfterFirePiercing,
		// Token: 0x040006DF RID: 1759
		ChangeAmmoAfterFireFire,
		// Token: 0x040006E0 RID: 1760
		ChangeAmmoAfterFireLightning,
		// Token: 0x040006E1 RID: 1761
		ChangeAmmoAfterFireIce,
		// Token: 0x040006E2 RID: 1762
		ChangeAmmoAfterFirePiercingMoving,
		// Token: 0x040006E3 RID: 1763
		ChangeAmmoAfterFireFireMoving,
		// Token: 0x040006E4 RID: 1764
		ChangeAmmoAfterFireLightningMoving,
		// Token: 0x040006E5 RID: 1765
		ChangeAmmoAfterFireIceMoving,
		// Token: 0x040006E6 RID: 1766
		DoryaniHumanBossActivateMechanism,
		// Token: 0x040006E7 RID: 1767
		DoryaniHumanBossBeamBlast,
		// Token: 0x040006E8 RID: 1768
		BlazingCluster,
		// Token: 0x040006E9 RID: 1769
		VaultingImpact,
		// Token: 0x040006EA RID: 1770
		VaultingImpactMoving,
		// Token: 0x040006EB RID: 1771
		VaultingImpactShort,
		// Token: 0x040006EC RID: 1772
		VaultingImpactMovingShort,
		// Token: 0x040006ED RID: 1773
		StormWave,
		// Token: 0x040006EE RID: 1774
		MantraOfDestruction,
		// Token: 0x040006EF RID: 1775
		DodgeRollMoveCancel,
		// Token: 0x040006F0 RID: 1776
		DodgeRollBackMoveCancel,
		// Token: 0x040006F1 RID: 1777
		WarBanner,
		// Token: 0x040006F2 RID: 1778
		BreakingWave,
		// Token: 0x040006F3 RID: 1779
		FreezingWord,
		// Token: 0x040006F4 RID: 1780
		IceSpikes,
		// Token: 0x040006F5 RID: 1781
		ThrowFlask,
		// Token: 0x040006F6 RID: 1782
		VoltaicMark,
		// Token: 0x040006F7 RID: 1783
		VoltaicMarkFlipped,
		// Token: 0x040006F8 RID: 1784
		HandOfChayula,
		// Token: 0x040006F9 RID: 1785
		DefianceBanner,
		// Token: 0x040006FA RID: 1786
		TemporalChains,
		// Token: 0x040006FB RID: 1787
		PlayerBedIdle,
		// Token: 0x040006FC RID: 1788
		PlayerBedGetup,
		// Token: 0x040006FD RID: 1789
		TimeSnap,
		// Token: 0x040006FE RID: 1790
		SpellAreaOfEffectMoving,
		// Token: 0x040006FF RID: 1791
		DreadBanner,
		// Token: 0x04000700 RID: 1792
		PowerShotLightningCharge,
		// Token: 0x04000701 RID: 1793
		ShapeshiftHumanToDemon,
		// Token: 0x04000702 RID: 1794
		ShapeshiftDemonToHuman,
		// Token: 0x04000703 RID: 1795
		ClusterGrenade,
		// Token: 0x04000704 RID: 1796
		ThroneIdle,
		// Token: 0x04000705 RID: 1797
		ThroneSitDown,
		// Token: 0x04000706 RID: 1798
		ThroneGetUp,
		// Token: 0x04000707 RID: 1799
		ExplosiveConcoction,
		// Token: 0x04000708 RID: 1800
		FulminatingConcoction,
		// Token: 0x04000709 RID: 1801
		ShatteringConcoction,
		// Token: 0x0400070A RID: 1802
		PoisonousConcoction,
		// Token: 0x0400070B RID: 1803
		BleedingConcoction,
		// Token: 0x0400070C RID: 1804
		ThrowFlaskAimUpMainHand,
		// Token: 0x0400070D RID: 1805
		ThrowFlaskAimUpOffHand,
		// Token: 0x0400070E RID: 1806
		ThrowFlaskAimDownMainHand,
		// Token: 0x0400070F RID: 1807
		ThrowFlaskAimDownOffHand,
		// Token: 0x04000710 RID: 1808
		InteractSanctumHonourShrine,
		// Token: 0x04000711 RID: 1809
		BoatIdle,
		// Token: 0x04000712 RID: 1810
		PersistentIdleFemale,
		// Token: 0x04000713 RID: 1811
		PersistentIdleDemonSkill,
		// Token: 0x04000714 RID: 1812
		PersistentIdleDemonEmerge,
		// Token: 0x04000715 RID: 1813
		GatheringStorm,
		// Token: 0x04000716 RID: 1814
		GatheringStormEnd,
		// Token: 0x04000717 RID: 1815
		GatheringStormPerfectEnd,
		// Token: 0x04000718 RID: 1816
		ShockwaveTotem,
		// Token: 0x04000719 RID: 1817
		ShockwaveTotemFOW,
		// Token: 0x0400071A RID: 1818
		FixedRunLayerBaseChannelBuff,
		// Token: 0x0400071B RID: 1819
		Ascend,
		// Token: 0x0400071C RID: 1820
		AscendEnd,
		// Token: 0x0400071D RID: 1821
		DeliriumBossFireStart,
		// Token: 0x0400071E RID: 1822
		DeliriumBossFireLoop,
		// Token: 0x0400071F RID: 1823
		DeliriumBossFireEnd,
		// Token: 0x04000720 RID: 1824
		DeliriumBossLightningStart,
		// Token: 0x04000721 RID: 1825
		DeliriumBossLightningLoop,
		// Token: 0x04000722 RID: 1826
		DeliriumBossLightningEnd,
		// Token: 0x04000723 RID: 1827
		JadeArmour,
		// Token: 0x04000724 RID: 1828
		JadeArmourEnd,
		// Token: 0x04000725 RID: 1829
		InteractUltimatumPlaceSoulCore,
		// Token: 0x04000726 RID: 1830
		TeleportStationary,
		// Token: 0x04000727 RID: 1831
		TeleportBackStationary,
		// Token: 0x04000728 RID: 1832
		Cataclysm,
		// Token: 0x04000729 RID: 1833
		CataclysmLoop,
		// Token: 0x0400072A RID: 1834
		IntroZombieStab,
		// Token: 0x0400072B RID: 1835
		IdleLayerBaseStaticChannelBuff,
		// Token: 0x0400072C RID: 1836
		SanctumDeath,
		// Token: 0x0400072D RID: 1837
		FloatIdleLayer,
		// Token: 0x0400072E RID: 1838
		FloatHeightLayer,
		// Token: 0x0400072F RID: 1839
		FloatDodgeRoll,
		// Token: 0x04000730 RID: 1840
		FloatDodgeRollBack,
		// Token: 0x04000731 RID: 1841
		ShapeshiftWyvernToHuman,
		// Token: 0x04000732 RID: 1842
		WyvernMaul,
		// Token: 0x04000733 RID: 1843
		ShapeshiftWyvernMaul,
		// Token: 0x04000734 RID: 1844
		HeadHuntHeartStab,
		// Token: 0x04000735 RID: 1845
		HeadHuntSelfStabMoving,
		// Token: 0x04000736 RID: 1846
		EngageStationary,
		// Token: 0x04000737 RID: 1847
		SpearDischarge,
		// Token: 0x04000738 RID: 1848
		HeadHuntSelfStabStationary,
		// Token: 0x04000739 RID: 1849
		WindstormLance,
		// Token: 0x0400073A RID: 1850
		PrimalStrikes,
		// Token: 0x0400073B RID: 1851
		FrostWhirl,
		// Token: 0x0400073C RID: 1852
		SerpentSpear,
		// Token: 0x0400073D RID: 1853
		SerpentSpearMoving,
		// Token: 0x0400073E RID: 1854
		Rake,
		// Token: 0x0400073F RID: 1855
		RakeShortDash,
		// Token: 0x04000740 RID: 1856
		RakeStationary,
		// Token: 0x04000741 RID: 1857
		SpearWindVortexMoving,
		// Token: 0x04000742 RID: 1858
		ParryChannel,
		// Token: 0x04000743 RID: 1859
		ParryEnd,
		// Token: 0x04000744 RID: 1860
		PerfectParryEnd,
		// Token: 0x04000745 RID: 1861
		OverchargedSpear,
		// Token: 0x04000746 RID: 1862
		HuntersMark,
		// Token: 0x04000747 RID: 1863
		HuntersMarkFlipped,
		// Token: 0x04000748 RID: 1864
		TameBeast,
		// Token: 0x04000749 RID: 1865
		SolarisSpear,
		// Token: 0x0400074A RID: 1866
		ExtractElements,
		// Token: 0x0400074B RID: 1867
		BlazingLance,
		// Token: 0x0400074C RID: 1868
		SpearStanceSwitch,
		// Token: 0x0400074D RID: 1869
		MeleeCombo,
		// Token: 0x0400074E RID: 1870
		MeleeFire,
		// Token: 0x0400074F RID: 1871
		MeleeFireCombo,
		// Token: 0x04000750 RID: 1872
		MeleeCold,
		// Token: 0x04000751 RID: 1873
		MeleeColdCombo,
		// Token: 0x04000752 RID: 1874
		MeleeLightning,
		// Token: 0x04000753 RID: 1875
		MeleeLightningCombo,
		// Token: 0x04000754 RID: 1876
		MeleeChaos,
		// Token: 0x04000755 RID: 1877
		MeleeChaosCombo,
		// Token: 0x04000756 RID: 1878
		InfusingStrike,
		// Token: 0x04000757 RID: 1879
		InfusingStrikeMoving,
		// Token: 0x04000758 RID: 1880
		Haunt,
		// Token: 0x04000759 RID: 1881
		BasicSpearThrow,
		// Token: 0x0400075A RID: 1882
		InteractHandCut,
		// Token: 0x0400075B RID: 1883
		SpectreDeath,
		// Token: 0x0400075C RID: 1884
		SpectreSurplusDeath,
		// Token: 0x0400075D RID: 1885
		ChannelImbueWeapon,
		// Token: 0x0400075E RID: 1886
		ChannelImbueWeaponEnd,
		// Token: 0x0400075F RID: 1887
		FixedIdleLayerBaseMountedAlt,
		// Token: 0x04000760 RID: 1888
		Convalescence,
		// Token: 0x04000761 RID: 1889
		Firebolt,
		// Token: 0x04000762 RID: 1890
		ConsumePet,
		// Token: 0x04000763 RID: 1891
		FrenziedLunge,
		// Token: 0x04000764 RID: 1892
		FrenziedLungeMoving
	}
}
