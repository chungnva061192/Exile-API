using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ExileCore2.PoEMemory.FilesInMemory
{
	// Token: 0x02000269 RID: 617
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StatHandling
	{
		// Token: 0x04008141 RID: 33089
		NoFunction = 1,
		// Token: 0x04008142 RID: 33090
		Negate,
		// Token: 0x04008143 RID: 33091
		PerMinuteToPerSecond,
		// Token: 0x04008144 RID: 33092
		PerMinuteToPerSecond0dp,
		// Token: 0x04008145 RID: 33093
		PerMinuteToPerSecond1dp,
		// Token: 0x04008146 RID: 33094
		PerMinuteToPerSecond2dp,
		// Token: 0x04008147 RID: 33095
		PerMinuteToPerSecond2dpIfRequired,
		// Token: 0x04008148 RID: 33096
		PermyriadPerMinuteToPercentPerSecond,
		// Token: 0x04008149 RID: 33097
		DecisecondsToSeconds,
		// Token: 0x0400814A RID: 33098
		MillisecondsToSeconds,
		// Token: 0x0400814B RID: 33099
		MillisecondsToSeconds0dp,
		// Token: 0x0400814C RID: 33100
		MillisecondsToSeconds1dp,
		// Token: 0x0400814D RID: 33101
		MillisecondsToSeconds2dp,
		// Token: 0x0400814E RID: 33102
		MillisecondsToSeconds2dpIfRequired,
		// Token: 0x0400814F RID: 33103
		DivideByOneHundred,
		// Token: 0x04008150 RID: 33104
		DivideByOneHundred0dp,
		// Token: 0x04008151 RID: 33105
		DivideByOneHundred1dp,
		// Token: 0x04008152 RID: 33106
		DivideByOneHundred2dp,
		// Token: 0x04008153 RID: 33107
		DivideByOneHundredAndNegate,
		// Token: 0x04008154 RID: 33108
		MultiplicativeDamageModifier,
		// Token: 0x04008155 RID: 33109
		ModValueToItemClass,
		// Token: 0x04008156 RID: 33110
		MultiplicativePermyriadDamageModifier,
		// Token: 0x04008157 RID: 33111
		OldLeechPercent,
		// Token: 0x04008158 RID: 33112
		OldLeechPermyriad,
		// Token: 0x04008159 RID: 33113
		TempestModText,
		// Token: 0x0400815A RID: 33114
		SixtyPercentOfValue,
		// Token: 0x0400815B RID: 33115
		ThirtyPercentOfValue,
		// Token: 0x0400815C RID: 33116
		DivideByTen0dp,
		// Token: 0x0400815D RID: 33117
		DivideByTwentyThenDouble0dp,
		// Token: 0x0400815E RID: 33118
		DivideByFifteen0dp,
		// Token: 0x0400815F RID: 33119
		DivideByTwo0dp,
		// Token: 0x04008160 RID: 33120
		MultiplyByEightyThenMsToSeconds0dp,
		// Token: 0x04008161 RID: 33121
		TimesTwenty,
		// Token: 0x04008162 RID: 33122
		DivideByTwelve,
		// Token: 0x04008163 RID: 33123
		DivideBySix,
		// Token: 0x04008164 RID: 33124
		PassiveHash,
		// Token: 0x04008165 RID: 33125
		IndexToTreeExpansionJewelPassive,
		// Token: 0x04008166 RID: 33126
		AfflictionRewardType,
		// Token: 0x04008167 RID: 33127
		DisplayIndexableSupport,
		// Token: 0x04008168 RID: 33128
		DivideByFive,
		// Token: 0x04008169 RID: 33129
		DivideByThree,
		// Token: 0x0400816A RID: 33130
		MultiplyByFour,
		// Token: 0x0400816B RID: 33131
		MultiplyByFourAndNegate,
		// Token: 0x0400816C RID: 33132
		MillisecondsToSecondsHalved,
		// Token: 0x0400816D RID: 33133
		DivideByTen1dp,
		// Token: 0x0400816E RID: 33134
		DivideByTen1dpIfRequired,
		// Token: 0x0400816F RID: 33135
		DivideByOneHundred2dpIfRequired,
		// Token: 0x04008170 RID: 33136
		NegateAndDouble,
		// Token: 0x04008171 RID: 33137
		Double,
		// Token: 0x04008172 RID: 33138
		TimesOnePointFive,
		// Token: 0x04008173 RID: 33139
		DivideByFour,
		// Token: 0x04008174 RID: 33140
		DivideByFifty,
		// Token: 0x04008175 RID: 33141
		MultiplyByTen,
		// Token: 0x04008176 RID: 33142
		DivideByOneThousand,
		// Token: 0x04008177 RID: 33143
		PlusTwoHundred,
		// Token: 0x04008178 RID: 33144
		WeaponTreeUniqueBaseTypeName,
		// Token: 0x04008179 RID: 33145
		DisplayIndexableSkill,
		// Token: 0x0400817A RID: 33146
		DivideByTwenty,
		// Token: 0x0400817B RID: 33147
		LocationUnitsToMetres,
		// Token: 0x0400817C RID: 33148
		InvertChance
	}
}
