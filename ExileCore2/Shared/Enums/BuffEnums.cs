using System;

namespace ExileCore2.Shared.Enums
{
	// Token: 0x02000133 RID: 307
	public enum BuffEnums
	{
		// Token: 0x0400076C RID: 1900
		none = -1,
		// Token: 0x0400076D RID: 1901
		ignited,
		// Token: 0x0400076E RID: 1902
		chilled,
		// Token: 0x0400076F RID: 1903
		frozen,
		// Token: 0x04000770 RID: 1904
		shocked,
		// Token: 0x04000771 RID: 1905
		sprinting,
		// Token: 0x04000772 RID: 1906
		flask_effect_life,
		// Token: 0x04000773 RID: 1907
		grace_period,
		// Token: 0x04000774 RID: 1908
		flask_effect_mana,
		// Token: 0x04000775 RID: 1909
		poison,
		// Token: 0x04000776 RID: 1910
		blood_rage,
		// Token: 0x04000777 RID: 1911
		righteous_fire,
		// Token: 0x04000778 RID: 1912
		righteous_fire_aura,
		// Token: 0x04000779 RID: 1913
		demon_righteous_fire,
		// Token: 0x0400077A RID: 1914
		demon_righteous_fire_aura,
		// Token: 0x0400077B RID: 1915
		avatar_righteous_fire,
		// Token: 0x0400077C RID: 1916
		avatar_righteous_fire_aura,
		// Token: 0x0400077D RID: 1917
		invisible_fire_aura,
		// Token: 0x0400077E RID: 1918
		invisible_fire_debuff,
		// Token: 0x0400077F RID: 1919
		invisible_holy_fire_debuff,
		// Token: 0x04000780 RID: 1920
		invisible_holy_fire_elder_debuff,
		// Token: 0x04000781 RID: 1921
		invisible_kitava_fire_debuff,
		// Token: 0x04000782 RID: 1922
		ion_beam_debuff,
		// Token: 0x04000783 RID: 1923
		frost_ion_beam_debuff,
		// Token: 0x04000784 RID: 1924
		fire_weapon,
		// Token: 0x04000785 RID: 1925
		frenzy_charge,
		// Token: 0x04000786 RID: 1926
		endurance_charge,
		// Token: 0x04000787 RID: 1927
		power_charge,
		// Token: 0x04000788 RID: 1928
		spirit_charge,
		// Token: 0x04000789 RID: 1929
		siphoning_charge,
		// Token: 0x0400078A RID: 1930
		void_arrow,
		// Token: 0x0400078B RID: 1931
		hillock_buff,
		// Token: 0x0400078C RID: 1932
		mana_leech,
		// Token: 0x0400078D RID: 1933
		life_leech,
		// Token: 0x0400078E RID: 1934
		energy_shield_leech,
		// Token: 0x0400078F RID: 1935
		players_increased,
		// Token: 0x04000790 RID: 1936
		flask_bonus_armour,
		// Token: 0x04000791 RID: 1937
		flask_bonus_evasion,
		// Token: 0x04000792 RID: 1938
		flask_bonus_energy_shield,
		// Token: 0x04000793 RID: 1939
		flask_bonus_movement_speed,
		// Token: 0x04000794 RID: 1940
		flask_bonus_stun_recovery,
		// Token: 0x04000795 RID: 1941
		flask_bonus_resistances,
		// Token: 0x04000796 RID: 1942
		flask_bonus_life_leech,
		// Token: 0x04000797 RID: 1943
		flask_bonus_mana_leech,
		// Token: 0x04000798 RID: 1944
		flask_bonus_knockback,
		// Token: 0x04000799 RID: 1945
		flask_bonus_global_knockback,
		// Token: 0x0400079A RID: 1946
		flask_bonus_prevents_death,
		// Token: 0x0400079B RID: 1947
		flask_bonus_chill_and_freeze_immunity,
		// Token: 0x0400079C RID: 1948
		flask_bonus_ignite_immunity,
		// Token: 0x0400079D RID: 1949
		flask_bonus_shock_immunity,
		// Token: 0x0400079E RID: 1950
		flask_bonus_bleeding_immunity,
		// Token: 0x0400079F RID: 1951
		flask_bonus_curse_immunity,
		// Token: 0x040007A0 RID: 1952
		spectre_buff,
		// Token: 0x040007A1 RID: 1953
		infernal_blow_hit,
		// Token: 0x040007A2 RID: 1954
		viper_strike_orb,
		// Token: 0x040007A3 RID: 1955
		phase_run,
		// Token: 0x040007A4 RID: 1956
		monster_magic_effect_buff,
		// Token: 0x040007A5 RID: 1957
		monster_rare_effect_buff,
		// Token: 0x040007A6 RID: 1958
		fuse_arrow_orb,
		// Token: 0x040007A7 RID: 1959
		curse_temporal_chains,
		// Token: 0x040007A8 RID: 1960
		curse_elemental_weakness,
		// Token: 0x040007A9 RID: 1961
		curse_fire_weakness,
		// Token: 0x040007AA RID: 1962
		curse_cold_weakness,
		// Token: 0x040007AB RID: 1963
		curse_lightning_weakness,
		// Token: 0x040007AC RID: 1964
		curse_warlords_mark,
		// Token: 0x040007AD RID: 1965
		curse_punishment,
		// Token: 0x040007AE RID: 1966
		curse_enfeeble,
		// Token: 0x040007AF RID: 1967
		curse_assassins_mark,
		// Token: 0x040007B0 RID: 1968
		curse_projectile_weakness,
		// Token: 0x040007B1 RID: 1969
		curse_vulnerability,
		// Token: 0x040007B2 RID: 1970
		curse_poachers_mark,
		// Token: 0x040007B3 RID: 1971
		curse_newpunishment,
		// Token: 0x040007B4 RID: 1972
		monster_aura_physical_thorns,
		// Token: 0x040007B5 RID: 1973
		monster_aura_elemental_thorns,
		// Token: 0x040007B6 RID: 1974
		monster_physical_thorns,
		// Token: 0x040007B7 RID: 1975
		monster_elemental_thorns,
		// Token: 0x040007B8 RID: 1976
		monster_aura_medium_physical_damage,
		// Token: 0x040007B9 RID: 1977
		monster_aura_large_physical_damage,
		// Token: 0x040007BA RID: 1978
		monster_aura_speed,
		// Token: 0x040007BB RID: 1979
		monster_aura_life_regen,
		// Token: 0x040007BC RID: 1980
		monster_aura_resists,
		// Token: 0x040007BD RID: 1981
		monster_aura_energy_shield,
		// Token: 0x040007BE RID: 1982
		monster_aura_energy_shield_bubble,
		// Token: 0x040007BF RID: 1983
		monster_aura_accuracy_and_crits,
		// Token: 0x040007C0 RID: 1984
		monster_aura_pus_puke_degen,
		// Token: 0x040007C1 RID: 1985
		monster_aura_chaos_degen,
		// Token: 0x040007C2 RID: 1986
		monster_aura_physical_degen,
		// Token: 0x040007C3 RID: 1987
		monster_aura_lightning_degen,
		// Token: 0x040007C4 RID: 1988
		monster_aura_elemental_damage,
		// Token: 0x040007C5 RID: 1989
		monster_aura_essence_daemon_degen,
		// Token: 0x040007C6 RID: 1990
		monster_thorns_physical,
		// Token: 0x040007C7 RID: 1991
		monster_thorns_elemental,
		// Token: 0x040007C8 RID: 1992
		monster_thorns_physical_large,
		// Token: 0x040007C9 RID: 1993
		monster_thorns_elemental_large,
		// Token: 0x040007CA RID: 1994
		monster_thorns_bloodline,
		// Token: 0x040007CB RID: 1995
		monster_thorns_bloodline_large_model,
		// Token: 0x040007CC RID: 1996
		dominated,
		// Token: 0x040007CD RID: 1997
		dominating_blow_hit_buff,
		// Token: 0x040007CE RID: 1998
		immortal_call,
		// Token: 0x040007CF RID: 1999
		vaal_immortal_call,
		// Token: 0x040007D0 RID: 2000
		lightning_shield,
		// Token: 0x040007D1 RID: 2001
		fire_shield,
		// Token: 0x040007D2 RID: 2002
		flask_utility_critical_strike_chance,
		// Token: 0x040007D3 RID: 2003
		flask_utility_resist_fire,
		// Token: 0x040007D4 RID: 2004
		flask_utility_resist_cold,
		// Token: 0x040007D5 RID: 2005
		flask_utility_resist_lightning,
		// Token: 0x040007D6 RID: 2006
		flask_utility_ironskin,
		// Token: 0x040007D7 RID: 2007
		flask_utility_sprint,
		// Token: 0x040007D8 RID: 2008
		flask_utility_resist_chaos,
		// Token: 0x040007D9 RID: 2009
		flask_utility_phase,
		// Token: 0x040007DA RID: 2010
		flask_utility_evasion,
		// Token: 0x040007DB RID: 2011
		flask_utility_stone,
		// Token: 0x040007DC RID: 2012
		flask_utility_aquamarine,
		// Token: 0x040007DD RID: 2013
		flask_utility_prismatic,
		// Token: 0x040007DE RID: 2014
		flask_utility_smoke,
		// Token: 0x040007DF RID: 2015
		flask_utility_consecrate,
		// Token: 0x040007E0 RID: 2016
		flask_utility_haste,
		// Token: 0x040007E1 RID: 2017
		elemental_equilibrium_buff,
		// Token: 0x040007E2 RID: 2018
		block_test,
		// Token: 0x040007E3 RID: 2019
		bleeding,
		// Token: 0x040007E4 RID: 2020
		bleeding_moving,
		// Token: 0x040007E5 RID: 2021
		player_aura_armour,
		// Token: 0x040007E6 RID: 2022
		player_aura_evasion,
		// Token: 0x040007E7 RID: 2023
		player_aura_resists,
		// Token: 0x040007E8 RID: 2024
		player_aura_fire_resist,
		// Token: 0x040007E9 RID: 2025
		player_aura_cold_resist,
		// Token: 0x040007EA RID: 2026
		player_aura_lightning_resist,
		// Token: 0x040007EB RID: 2027
		player_aura_energy_shield,
		// Token: 0x040007EC RID: 2028
		player_aura_fire_damage,
		// Token: 0x040007ED RID: 2029
		player_aura_cold_damage,
		// Token: 0x040007EE RID: 2030
		player_aura_lightning_damage,
		// Token: 0x040007EF RID: 2031
		player_aura_speed,
		// Token: 0x040007F0 RID: 2032
		player_aura_life_regen,
		// Token: 0x040007F1 RID: 2033
		power_shot_hit,
		// Token: 0x040007F2 RID: 2034
		player_aura_mana_regen,
		// Token: 0x040007F3 RID: 2035
		vaal_aura_armour,
		// Token: 0x040007F4 RID: 2036
		vaal_aura_life_regen,
		// Token: 0x040007F5 RID: 2037
		vaal_aura_no_mana_cost,
		// Token: 0x040007F6 RID: 2038
		vaal_aura_dodge,
		// Token: 0x040007F7 RID: 2039
		vaal_aura_energy_shield,
		// Token: 0x040007F8 RID: 2040
		vaal_aura_speed,
		// Token: 0x040007F9 RID: 2041
		beartrap_debuff,
		// Token: 0x040007FA RID: 2042
		trap_convert_buff,
		// Token: 0x040007FB RID: 2043
		ground_fire_burn,
		// Token: 0x040007FC RID: 2044
		ground_ice_chill,
		// Token: 0x040007FD RID: 2045
		ground_tar_slow,
		// Token: 0x040007FE RID: 2046
		monster_no_drops_buff,
		// Token: 0x040007FF RID: 2047
		totem_aura_life_regen,
		// Token: 0x04000800 RID: 2048
		totem_aura_life_mana_regen,
		// Token: 0x04000801 RID: 2049
		blinded,
		// Token: 0x04000802 RID: 2050
		ice_shield,
		// Token: 0x04000803 RID: 2051
		ice_shield_moving,
		// Token: 0x04000804 RID: 2052
		frozen_damage_increase,
		// Token: 0x04000805 RID: 2053
		lightning_thorns,
		// Token: 0x04000806 RID: 2054
		piety_fire_form,
		// Token: 0x04000807 RID: 2055
		piety_ice_form,
		// Token: 0x04000808 RID: 2056
		leaving_area_protection,
		// Token: 0x04000809 RID: 2057
		vinktar_lightning_bond_in_beam,
		// Token: 0x0400080A RID: 2058
		searing_bond_in_beam,
		// Token: 0x0400080B RID: 2059
		ground_desecration,
		// Token: 0x0400080C RID: 2060
		ground_consecration,
		// Token: 0x0400080D RID: 2061
		unique_flask_ghost_reaver,
		// Token: 0x0400080E RID: 2062
		unique_flask_zealots_oath,
		// Token: 0x0400080F RID: 2063
		unique_flask_zerphis_last_breath,
		// Token: 0x04000810 RID: 2064
		flask_immune_to_damage,
		// Token: 0x04000811 RID: 2065
		unique_flask_divination_distillate,
		// Token: 0x04000812 RID: 2066
		onslaught,
		// Token: 0x04000813 RID: 2067
		undying_rage,
		// Token: 0x04000814 RID: 2068
		unique_deaths_oath_aura,
		// Token: 0x04000815 RID: 2069
		unique_deaths_oath_debuff,
		// Token: 0x04000816 RID: 2070
		birdman_consume_corpse_buff,
		// Token: 0x04000817 RID: 2071
		damage_aura,
		// Token: 0x04000818 RID: 2072
		reave_counter,
		// Token: 0x04000819 RID: 2073
		chilling_bond_in_beam,
		// Token: 0x0400081A RID: 2074
		additional_totems_test,
		// Token: 0x0400081B RID: 2075
		dominus_mark,
		// Token: 0x0400081C RID: 2076
		manashield,
		// Token: 0x0400081D RID: 2077
		proximity_shield_aura,
		// Token: 0x0400081E RID: 2078
		incinerate_counter,
		// Token: 0x0400081F RID: 2079
		chilled_burn_damage_increase,
		// Token: 0x04000820 RID: 2080
		ground_lightning_shock,
		// Token: 0x04000821 RID: 2081
		ground_smoke_blind,
		// Token: 0x04000822 RID: 2082
		smoke_mine_movement_speed,
		// Token: 0x04000823 RID: 2083
		trapdamage,
		// Token: 0x04000824 RID: 2084
		unique_flask_tears_of_the_dybbuk_prince,
		// Token: 0x04000825 RID: 2085
		movement_speed_buff,
		// Token: 0x04000826 RID: 2086
		proximity_shield_buff,
		// Token: 0x04000827 RID: 2087
		freeze_mine_cold_resistsance_debuff,
		// Token: 0x04000828 RID: 2088
		corrupted_blood,
		// Token: 0x04000829 RID: 2089
		corrupted_blood_rain,
		// Token: 0x0400082A RID: 2090
		shrine_acceleration,
		// Token: 0x0400082B RID: 2091
		shrine_brutal,
		// Token: 0x0400082C RID: 2092
		shrine_thorns,
		// Token: 0x0400082D RID: 2093
		shrine_regen,
		// Token: 0x0400082E RID: 2094
		shrine_critical,
		// Token: 0x0400082F RID: 2095
		shrine_fire,
		// Token: 0x04000830 RID: 2096
		shrine_lightning,
		// Token: 0x04000831 RID: 2097
		shrine_cold,
		// Token: 0x04000832 RID: 2098
		shrine_arc,
		// Token: 0x04000833 RID: 2099
		shrine_smoke,
		// Token: 0x04000834 RID: 2100
		shrine_skeleton,
		// Token: 0x04000835 RID: 2101
		shrine_echoing,
		// Token: 0x04000836 RID: 2102
		shrine_curses,
		// Token: 0x04000837 RID: 2103
		shrine_massive,
		// Token: 0x04000838 RID: 2104
		shrine_defence,
		// Token: 0x04000839 RID: 2105
		shrine_godmode,
		// Token: 0x0400083A RID: 2106
		shrine_resistance,
		// Token: 0x0400083B RID: 2107
		farshot,
		// Token: 0x0400083C RID: 2108
		mine_trap_test,
		// Token: 0x0400083D RID: 2109
		animated_armour,
		// Token: 0x0400083E RID: 2110
		unique_flask_blood_of_the_karui,
		// Token: 0x0400083F RID: 2111
		unique_flask_laviangas_cup,
		// Token: 0x04000840 RID: 2112
		oba_death_buff,
		// Token: 0x04000841 RID: 2113
		nemesis_transformed,
		// Token: 0x04000842 RID: 2114
		curse_silence,
		// Token: 0x04000843 RID: 2115
		curse_aura_silence,
		// Token: 0x04000844 RID: 2116
		soul_eater_aura,
		// Token: 0x04000845 RID: 2117
		soul_eater,
		// Token: 0x04000846 RID: 2118
		nemesis_stealth_mode,
		// Token: 0x04000847 RID: 2119
		seawitch_lightning_beam,
		// Token: 0x04000848 RID: 2120
		usemax_life_regen,
		// Token: 0x04000849 RID: 2121
		statusailmenttest,
		// Token: 0x0400084A RID: 2122
		vortex_mine,
		// Token: 0x0400084B RID: 2123
		charged_blast_counter,
		// Token: 0x0400084C RID: 2124
		chill_prevention,
		// Token: 0x0400084D RID: 2125
		freeze_prevention,
		// Token: 0x0400084E RID: 2126
		ignite_prevention,
		// Token: 0x0400084F RID: 2127
		shock_prevention,
		// Token: 0x04000850 RID: 2128
		unique_dying_breath_curse_aura,
		// Token: 0x04000851 RID: 2129
		unique_dying_breath_damage_aura,
		// Token: 0x04000852 RID: 2130
		int_mission_dying_breath_aura,
		// Token: 0x04000853 RID: 2131
		sea_witch_screech_debuff,
		// Token: 0x04000854 RID: 2132
		offering_offensive,
		// Token: 0x04000855 RID: 2133
		offering_defensive,
		// Token: 0x04000856 RID: 2134
		unholy_might,
		// Token: 0x04000857 RID: 2135
		unholy_might_permanent,
		// Token: 0x04000858 RID: 2136
		unholy_might_from_flask,
		// Token: 0x04000859 RID: 2137
		daemon_delay,
		// Token: 0x0400085A RID: 2138
		fire_enrage,
		// Token: 0x0400085B RID: 2139
		atziri_fire_charge,
		// Token: 0x0400085C RID: 2140
		atziri_lightning_charge,
		// Token: 0x0400085D RID: 2141
		atziri_physical_charge,
		// Token: 0x0400085E RID: 2142
		unique_flask_atziris_promise,
		// Token: 0x0400085F RID: 2143
		kiweth_enrage,
		// Token: 0x04000860 RID: 2144
		pinned,
		// Token: 0x04000861 RID: 2145
		vaal_cloud_stack,
		// Token: 0x04000862 RID: 2146
		vaal_cloud,
		// Token: 0x04000863 RID: 2147
		cannot_die,
		// Token: 0x04000864 RID: 2148
		atziri_charge_requirement_reduction,
		// Token: 0x04000865 RID: 2149
		status_immunity_enrage,
		// Token: 0x04000866 RID: 2150
		upheavalbuff,
		// Token: 0x04000867 RID: 2151
		unique_flask_forbidden_taste,
		// Token: 0x04000868 RID: 2152
		darkexile_corruption,
		// Token: 0x04000869 RID: 2153
		darkseawitch_corruption,
		// Token: 0x0400086A RID: 2154
		rampage_stack,
		// Token: 0x0400086B RID: 2155
		unique_flask_rumis_concoction,
		// Token: 0x0400086C RID: 2156
		marauder_mission_have_idol,
		// Token: 0x0400086D RID: 2157
		cagan_darkness,
		// Token: 0x0400086E RID: 2158
		physical_immunity,
		// Token: 0x0400086F RID: 2159
		bleeding_movespeed_penalty,
		// Token: 0x04000870 RID: 2160
		mission_relic_grace,
		// Token: 0x04000871 RID: 2161
		mission_duelist_grace,
		// Token: 0x04000872 RID: 2162
		hound_effect_buff,
		// Token: 0x04000873 RID: 2163
		exile_arcane_buff,
		// Token: 0x04000874 RID: 2164
		oba_decapitated,
		// Token: 0x04000875 RID: 2165
		heal,
		// Token: 0x04000876 RID: 2166
		herald_of_ash,
		// Token: 0x04000877 RID: 2167
		herald_of_ice,
		// Token: 0x04000878 RID: 2168
		herald_of_thunder,
		// Token: 0x04000879 RID: 2169
		herald_of_thunder_active,
		// Token: 0x0400087A RID: 2170
		cannot_be_damaged,
		// Token: 0x0400087B RID: 2171
		mission_relic_praying,
		// Token: 0x0400087C RID: 2172
		mission_beast_corrupted,
		// Token: 0x0400087D RID: 2173
		mission_monster_target,
		// Token: 0x0400087E RID: 2174
		stun_display_buff,
		// Token: 0x0400087F RID: 2175
		visual_display_buff,
		// Token: 0x04000880 RID: 2176
		visual_display_buff_gargoyle,
		// Token: 0x04000881 RID: 2177
		mission_int_buff,
		// Token: 0x04000882 RID: 2178
		fire_damage_and_ignite,
		// Token: 0x04000883 RID: 2179
		cold_damage_and_freeze,
		// Token: 0x04000884 RID: 2180
		lightning_damage_and_shock,
		// Token: 0x04000885 RID: 2181
		strdex_mission_fire_damage,
		// Token: 0x04000886 RID: 2182
		strdex_mission_cold_damage,
		// Token: 0x04000887 RID: 2183
		strdex_mission_lightning_damage,
		// Token: 0x04000888 RID: 2184
		physical_damage_and_bleed,
		// Token: 0x04000889 RID: 2185
		monster_life_flask,
		// Token: 0x0400088A RID: 2186
		union_of_souls,
		// Token: 0x0400088B RID: 2187
		bloodlines_shrouded,
		// Token: 0x0400088C RID: 2188
		bloodlines_necrovigil,
		// Token: 0x0400088D RID: 2189
		bloodlines_damage_charge,
		// Token: 0x0400088E RID: 2190
		bloodlines_speed_charge,
		// Token: 0x0400088F RID: 2191
		cold_thorns,
		// Token: 0x04000890 RID: 2192
		monster_bloodlines_damage_reduction,
		// Token: 0x04000891 RID: 2193
		unique_flask_taste_of_hate,
		// Token: 0x04000892 RID: 2194
		damage_aura_skeleton_elite,
		// Token: 0x04000893 RID: 2195
		trap_nonplayer_immunity,
		// Token: 0x04000894 RID: 2196
		inspiring_cry,
		// Token: 0x04000895 RID: 2197
		kaom_archer_effect,
		// Token: 0x04000896 RID: 2198
		lb_kaom_archer_effect,
		// Token: 0x04000897 RID: 2199
		abyssal_cry,
		// Token: 0x04000898 RID: 2200
		unique_shapers_seed_regeneration,
		// Token: 0x04000899 RID: 2201
		vaal_aura_elemental_damage_healing,
		// Token: 0x0400089A RID: 2202
		fortify,
		// Token: 0x0400089B RID: 2203
		taunted,
		// Token: 0x0400089C RID: 2204
		blackguardzombie_speedbuff,
		// Token: 0x0400089D RID: 2205
		kaom_fire,
		// Token: 0x0400089E RID: 2206
		taunt_immunity,
		// Token: 0x0400089F RID: 2207
		stacking_ignite,
		// Token: 0x040008A0 RID: 2208
		stolen_mod_buff,
		// Token: 0x040008A1 RID: 2209
		ice_elemental_buff,
		// Token: 0x040008A2 RID: 2210
		fire_elemental_buff,
		// Token: 0x040008A3 RID: 2211
		chaos_elemental_buff,
		// Token: 0x040008A4 RID: 2212
		lightning_elemental_buff,
		// Token: 0x040008A5 RID: 2213
		culling_strike_aura,
		// Token: 0x040008A6 RID: 2214
		increased_item_rarity_aura,
		// Token: 0x040008A7 RID: 2215
		piety_fire_form_stacking_damage_taken,
		// Token: 0x040008A8 RID: 2216
		enduring_cry_life_regeneration,
		// Token: 0x040008A9 RID: 2217
		flame_golem_effects,
		// Token: 0x040008AA RID: 2218
		flame_golem_summoned_effects,
		// Token: 0x040008AB RID: 2219
		flame_golem_runic_effects,
		// Token: 0x040008AC RID: 2220
		new_punishment_buff,
		// Token: 0x040008AD RID: 2221
		totem_placement_buff,
		// Token: 0x040008AE RID: 2222
		new_arctic_armour,
		// Token: 0x040008AF RID: 2223
		new_arctic_armour_stationary,
		// Token: 0x040008B0 RID: 2224
		unique_flask_lions_roar,
		// Token: 0x040008B1 RID: 2225
		revenant_revive_possessed,
		// Token: 0x040008B2 RID: 2226
		revenant_revive_explode,
		// Token: 0x040008B3 RID: 2227
		unique_flask_chaos_damage_damages_es,
		// Token: 0x040008B4 RID: 2228
		unique_flask_es_regen,
		// Token: 0x040008B5 RID: 2229
		blood_rage_xandro,
		// Token: 0x040008B6 RID: 2230
		malachai_invulnerable,
		// Token: 0x040008B7 RID: 2231
		exploding_storm_buff,
		// Token: 0x040008B8 RID: 2232
		diamond_storm,
		// Token: 0x040008B9 RID: 2233
		uber_diamond_storm,
		// Token: 0x040008BA RID: 2234
		replenishing_storm,
		// Token: 0x040008BB RID: 2235
		echoing_storm,
		// Token: 0x040008BC RID: 2236
		divine_storm,
		// Token: 0x040008BD RID: 2237
		rarity_storm,
		// Token: 0x040008BE RID: 2238
		uber_rarity_storm,
		// Token: 0x040008BF RID: 2239
		massive_storm,
		// Token: 0x040008C0 RID: 2240
		tiny_storm,
		// Token: 0x040008C1 RID: 2241
		fire_damage_storm,
		// Token: 0x040008C2 RID: 2242
		cold_damage_storm,
		// Token: 0x040008C3 RID: 2243
		lightning_damage_storm,
		// Token: 0x040008C4 RID: 2244
		smoke_trail_storm,
		// Token: 0x040008C5 RID: 2245
		corpse_devour_storm,
		// Token: 0x040008C6 RID: 2246
		projectile_nova_storm,
		// Token: 0x040008C7 RID: 2247
		veil_storm,
		// Token: 0x040008C8 RID: 2248
		voltaxic_storm,
		// Token: 0x040008C9 RID: 2249
		phasing_storm,
		// Token: 0x040008CA RID: 2250
		corrupted_drops_storm,
		// Token: 0x040008CB RID: 2251
		drop_as_sell_price_storm,
		// Token: 0x040008CC RID: 2252
		quality_drops_storm,
		// Token: 0x040008CD RID: 2253
		identify_items_storm,
		// Token: 0x040008CE RID: 2254
		arcane_storm,
		// Token: 0x040008CF RID: 2255
		status_immunity_storm,
		// Token: 0x040008D0 RID: 2256
		ground_spore_damage,
		// Token: 0x040008D1 RID: 2257
		flask_bonus_item_rarity,
		// Token: 0x040008D2 RID: 2258
		map_boss_duet_enrage,
		// Token: 0x040008D3 RID: 2259
		ground_spores,
		// Token: 0x040008D4 RID: 2260
		new_phase_run,
		// Token: 0x040008D5 RID: 2261
		new_phase_run_damage,
		// Token: 0x040008D6 RID: 2262
		tempest_soul_eater,
		// Token: 0x040008D7 RID: 2263
		static_tether,
		// Token: 0x040008D8 RID: 2264
		flask_bonus_mana_regeneration_rate,
		// Token: 0x040008D9 RID: 2265
		flask_bonus_flask_charge_recovery,
		// Token: 0x040008DA RID: 2266
		frost_bomb,
		// Token: 0x040008DB RID: 2267
		lightning_bomb,
		// Token: 0x040008DC RID: 2268
		borrowed_power_lightning_aura,
		// Token: 0x040008DD RID: 2269
		sawblade_damage,
		// Token: 0x040008DE RID: 2270
		usemax_mana_regen,
		// Token: 0x040008DF RID: 2271
		righteous_lightning,
		// Token: 0x040008E0 RID: 2272
		righteous_lightning_aura,
		// Token: 0x040008E1 RID: 2273
		life_leech_damage,
		// Token: 0x040008E2 RID: 2274
		enchantment_added_fire_damage,
		// Token: 0x040008E3 RID: 2275
		enchantment_dodge_chance,
		// Token: 0x040008E4 RID: 2276
		talisman_monster,
		// Token: 0x040008E5 RID: 2277
		caustic_cloud,
		// Token: 0x040008E6 RID: 2278
		enchantment_reduced_mana_cost,
		// Token: 0x040008E7 RID: 2279
		enchantment_stun_avoid,
		// Token: 0x040008E8 RID: 2280
		enchantment_spell_dodge,
		// Token: 0x040008E9 RID: 2281
		enchantment_attack_and_cast_speed,
		// Token: 0x040008EA RID: 2282
		enchantment_added_cold_damage,
		// Token: 0x040008EB RID: 2283
		enchantment_life_and_mana_leech,
		// Token: 0x040008EC RID: 2284
		enchantment_life_mana_regen,
		// Token: 0x040008ED RID: 2285
		attack_speed_when_hit,
		// Token: 0x040008EE RID: 2286
		berserker_life_and_mana_leech,
		// Token: 0x040008EF RID: 2287
		added_fire_damage,
		// Token: 0x040008F0 RID: 2288
		attack_and_cast_speed,
		// Token: 0x040008F1 RID: 2289
		physical_damage_stacking,
		// Token: 0x040008F2 RID: 2290
		block_chance,
		// Token: 0x040008F3 RID: 2291
		damage,
		// Token: 0x040008F4 RID: 2292
		taunted_special,
		// Token: 0x040008F5 RID: 2293
		damage_and_movement_speed,
		// Token: 0x040008F6 RID: 2294
		scion_movement_speed,
		// Token: 0x040008F7 RID: 2295
		siphon_damage,
		// Token: 0x040008F8 RID: 2296
		contagion,
		// Token: 0x040008F9 RID: 2297
		hinder,
		// Token: 0x040008FA RID: 2298
		wither_resistance,
		// Token: 0x040008FB RID: 2299
		siphon_leech,
		// Token: 0x040008FC RID: 2300
		rallying_cry_damage_added_as_mana,
		// Token: 0x040008FD RID: 2301
		offering_of_judgement_fire,
		// Token: 0x040008FE RID: 2302
		offering_of_judgement_chaos,
		// Token: 0x040008FF RID: 2303
		offering_of_judgement_counter,
		// Token: 0x04000900 RID: 2304
		her_blessing,
		// Token: 0x04000901 RID: 2305
		maim,
		// Token: 0x04000902 RID: 2306
		lightning_flask,
		// Token: 0x04000903 RID: 2307
		lightning_flask_attack_damage,
		// Token: 0x04000904 RID: 2308
		lightning_flask_spell_damage,
		// Token: 0x04000905 RID: 2309
		lightning_flask_physical_to_lightning,
		// Token: 0x04000906 RID: 2310
		lightning_flask_lightning_penetration,
		// Token: 0x04000907 RID: 2311
		shock_aura,
		// Token: 0x04000908 RID: 2312
		trap_pinned,
		// Token: 0x04000909 RID: 2313
		stacking_increased_spell_damage,
		// Token: 0x0400090A RID: 2314
		templar_ascendency_movement_speed,
		// Token: 0x0400090B RID: 2315
		guardian_warcry,
		// Token: 0x0400090C RID: 2316
		avoid_stun_staff_aura,
		// Token: 0x0400090D RID: 2317
		flying_roomba_damage,
		// Token: 0x0400090E RID: 2318
		offering_of_judgement_ground,
		// Token: 0x0400090F RID: 2319
		curse_damage_taken,
		// Token: 0x04000910 RID: 2320
		increased_crit_chance,
		// Token: 0x04000911 RID: 2321
		increased_minion_damage,
		// Token: 0x04000912 RID: 2322
		increased_damage,
		// Token: 0x04000913 RID: 2323
		damage_taken,
		// Token: 0x04000914 RID: 2324
		avoid_stun,
		// Token: 0x04000915 RID: 2325
		spinning_blade_damage,
		// Token: 0x04000916 RID: 2326
		stacking_movement_speed_buff,
		// Token: 0x04000917 RID: 2327
		nightwane_effects,
		// Token: 0x04000918 RID: 2328
		increased_elemental_damage_taken,
		// Token: 0x04000919 RID: 2329
		mana_and_es_regeneration,
		// Token: 0x0400091A RID: 2330
		vinktar_boss_buff,
		// Token: 0x0400091B RID: 2331
		grant_es_to_nearby_allies,
		// Token: 0x0400091C RID: 2332
		grant_armour_to_nearby_allies,
		// Token: 0x0400091D RID: 2333
		singularity_aura,
		// Token: 0x0400091E RID: 2334
		power_symbol_aura,
		// Token: 0x0400091F RID: 2335
		gargoyle_statue_buff,
		// Token: 0x04000920 RID: 2336
		vinktar_lightning_bond,
		// Token: 0x04000921 RID: 2337
		killed_rare_monsters_drop_uniques,
		// Token: 0x04000922 RID: 2338
		savage_hit_life_leech,
		// Token: 0x04000923 RID: 2339
		savage_hit_damage,
		// Token: 0x04000924 RID: 2340
		savage_hit_attack_cast_speed,
		// Token: 0x04000925 RID: 2341
		savage_hit_attack_speed,
		// Token: 0x04000926 RID: 2342
		melee_physical_damage,
		// Token: 0x04000927 RID: 2343
		grasping_ornaments_slow_aura,
		// Token: 0x04000928 RID: 2344
		grasping_tentacles_slow_aura,
		// Token: 0x04000929 RID: 2345
		grasping_pincers_slow_aura,
		// Token: 0x0400092A RID: 2346
		labyrinth_boss_grace,
		// Token: 0x0400092B RID: 2347
		izaro_summon_lieutenant_delay,
		// Token: 0x0400092C RID: 2348
		shield_defence_aura,
		// Token: 0x0400092D RID: 2349
		labyrinth_trap_bleed,
		// Token: 0x0400092E RID: 2350
		mine_detonation,
		// Token: 0x0400092F RID: 2351
		augry_of_penitence,
		// Token: 0x04000930 RID: 2352
		scion_augry_of_penitence,
		// Token: 0x04000931 RID: 2353
		labyrinth_power_symbol_shield,
		// Token: 0x04000932 RID: 2354
		awaken_gargoyle,
		// Token: 0x04000933 RID: 2355
		spell_damage_increase,
		// Token: 0x04000934 RID: 2356
		attack_damage_increase,
		// Token: 0x04000935 RID: 2357
		attack_speed_increase,
		// Token: 0x04000936 RID: 2358
		cast_speed_increase,
		// Token: 0x04000937 RID: 2359
		life_es_and_mana_recovery,
		// Token: 0x04000938 RID: 2360
		rock_golem_buff,
		// Token: 0x04000939 RID: 2361
		talisman_totem_effects,
		// Token: 0x0400093A RID: 2362
		spike_trap_immunity,
		// Token: 0x0400093B RID: 2363
		labyrinth_arrow_slow,
		// Token: 0x0400093C RID: 2364
		shrink,
		// Token: 0x0400093D RID: 2365
		lightning_eye_effects,
		// Token: 0x0400093E RID: 2366
		talisman_degen,
		// Token: 0x0400093F RID: 2367
		blade_vortex_counter,
		// Token: 0x04000940 RID: 2368
		soul_eater_from_stat_parent,
		// Token: 0x04000941 RID: 2369
		LocustSwarmStackingDegenAuraFire,
		// Token: 0x04000942 RID: 2370
		LocustSwarmStackingDegenAuraCold,
		// Token: 0x04000943 RID: 2371
		LocustSwarmStackingDegenAuraLightning,
		// Token: 0x04000944 RID: 2372
		rigwald_channeling,
		// Token: 0x04000945 RID: 2373
		blade_vortex,
		// Token: 0x04000946 RID: 2374
		elemental_overload,
		// Token: 0x04000947 RID: 2375
		frost_nova_counter,
		// Token: 0x04000948 RID: 2376
		heirophant_attack_and_spell_damage,
		// Token: 0x04000949 RID: 2377
		heirophant_additional_totems,
		// Token: 0x0400094A RID: 2378
		petrified,
		// Token: 0x0400094B RID: 2379
		flask_petrification,
		// Token: 0x0400094C RID: 2380
		blight,
		// Token: 0x0400094D RID: 2381
		flask_bonus_poison_immunity,
		// Token: 0x0400094E RID: 2382
		flask_bonus_physical_damage_reduction_percent,
		// Token: 0x0400094F RID: 2383
		life_regen_from_spread_poison,
		// Token: 0x04000950 RID: 2384
		elementalist_increased_fire_damage,
		// Token: 0x04000951 RID: 2385
		elementalist_increased_lightning_damage,
		// Token: 0x04000952 RID: 2386
		elementalist_increased_cold_damage,
		// Token: 0x04000953 RID: 2387
		elementalist_increased_elemental_damage,
		// Token: 0x04000954 RID: 2388
		elementalist_cold_penetration,
		// Token: 0x04000955 RID: 2389
		elementalist_fire_penetration,
		// Token: 0x04000956 RID: 2390
		elementalist_lightning_penetration,
		// Token: 0x04000957 RID: 2391
		elemental_conflux,
		// Token: 0x04000958 RID: 2392
		elementalist_increased_fire_damage_taken,
		// Token: 0x04000959 RID: 2393
		elementalist_increased_lightning_damage_taken,
		// Token: 0x0400095A RID: 2394
		elementalist_increased_cold_damage_taken,
		// Token: 0x0400095B RID: 2395
		elementalist_increased_elemental_damage_cooldown,
		// Token: 0x0400095C RID: 2396
		occultist_non_chaos_to_chaos_damage,
		// Token: 0x0400095D RID: 2397
		occultist_nearby_enemies_chaos_resist_life_regen,
		// Token: 0x0400095E RID: 2398
		occultist_no_energy_shield_recharge_delay,
		// Token: 0x0400095F RID: 2399
		izaro_elemental_fire_buff_phase1,
		// Token: 0x04000960 RID: 2400
		izaro_elemental_fire_buff,
		// Token: 0x04000961 RID: 2401
		izaro_elemental_cold_buff_phase1,
		// Token: 0x04000962 RID: 2402
		izaro_elemental_cold_buff,
		// Token: 0x04000963 RID: 2403
		izaro_elemental_lightning_buff_phase1,
		// Token: 0x04000964 RID: 2404
		izaro_elemental_lightning_buff,
		// Token: 0x04000965 RID: 2405
		charged_attack,
		// Token: 0x04000966 RID: 2406
		petrify_enrage,
		// Token: 0x04000967 RID: 2407
		occultist_stacking_es_recovery_per_minute_percent,
		// Token: 0x04000968 RID: 2408
		izaro_chronos_statue_damage_phase1,
		// Token: 0x04000969 RID: 2409
		izaro_chronos_statue_damage,
		// Token: 0x0400096A RID: 2410
		izaro_chronos_statue_speed_phase1,
		// Token: 0x0400096B RID: 2411
		izaro_chronos_statue_speed,
		// Token: 0x0400096C RID: 2412
		izaro_chronos_statue_damage_taken_phase1,
		// Token: 0x0400096D RID: 2413
		izaro_chronos_statue_damage_taken,
		// Token: 0x0400096E RID: 2414
		izaro_gargoyles_damage_buff_phase1,
		// Token: 0x0400096F RID: 2415
		izaro_gargoyles_damage_buff,
		// Token: 0x04000970 RID: 2416
		izaro_gargoyles_speed_buff_phase1,
		// Token: 0x04000971 RID: 2417
		izaro_gargoyles_speed_buff,
		// Token: 0x04000972 RID: 2418
		izaro_gargoyles_damage_taken_buff_phase1,
		// Token: 0x04000973 RID: 2419
		izaro_gargoyles_damage_taken_buff,
		// Token: 0x04000974 RID: 2420
		izaro_pedestals_physical_damage_reduction_buff_phase__1,
		// Token: 0x04000975 RID: 2421
		izaro_pedestals_physical_damage_reduction_buff,
		// Token: 0x04000976 RID: 2422
		izaro_pedestals_physical_damage_buff_phase__1,
		// Token: 0x04000977 RID: 2423
		izaro_pedestals_physical_damage_buff,
		// Token: 0x04000978 RID: 2424
		izaro_pedestals_additional_energy_shield_phase__1,
		// Token: 0x04000979 RID: 2425
		izaro_pedestals_additional_energy_shield,
		// Token: 0x0400097A RID: 2426
		izaro_charge,
		// Token: 0x0400097B RID: 2427
		izaro_super_charge,
		// Token: 0x0400097C RID: 2428
		offering_spirit,
		// Token: 0x0400097D RID: 2429
		totem_aura_chieftain,
		// Token: 0x0400097E RID: 2430
		guardian_share_charges_with_party_members_in_aura,
		// Token: 0x0400097F RID: 2431
		guardian_conduit_aura_enemies,
		// Token: 0x04000980 RID: 2432
		guardian_dispel_cooldown,
		// Token: 0x04000981 RID: 2433
		guardian_life_regen,
		// Token: 0x04000982 RID: 2434
		izaro_disrupter_inactive,
		// Token: 0x04000983 RID: 2435
		izaro_buff_loot_bonus,
		// Token: 0x04000984 RID: 2436
		melee_ancestor_totem_attack_speed,
		// Token: 0x04000985 RID: 2437
		slash_ancestor_totem_phys_added_as_fire,
		// Token: 0x04000986 RID: 2438
		slam_ancestor_totem_melee_damage,
		// Token: 0x04000987 RID: 2439
		guardian_cannot_be_stunned_aura,
		// Token: 0x04000988 RID: 2440
		izaro_pedestal_timer_buff,
		// Token: 0x04000989 RID: 2441
		lightning_golem_wrath,
		// Token: 0x0400098A RID: 2442
		chronos_statues_buff,
		// Token: 0x0400098B RID: 2443
		damage_increase_when_killed_bleeding_enemy,
		// Token: 0x0400098C RID: 2444
		damage_increase_when_killed_cursed_enemy,
		// Token: 0x0400098D RID: 2445
		increased_minion_attack_and_cast_speed,
		// Token: 0x0400098E RID: 2446
		increased_attack_and_cast_speed,
		// Token: 0x0400098F RID: 2447
		curse_enemy_chaos_resistance,
		// Token: 0x04000990 RID: 2448
		guardian_increased_attack_and_cast_speed,
		// Token: 0x04000991 RID: 2449
		guardian_increased_damage,
		// Token: 0x04000992 RID: 2450
		champion_aura_increased_damage_under_fortify,
		// Token: 0x04000993 RID: 2451
		enrage_buff,
		// Token: 0x04000994 RID: 2452
		elemental_penetration_from_mine_detonation,
		// Token: 0x04000995 RID: 2453
		have_killed_recently,
		// Token: 0x04000996 RID: 2454
		number_of_times_have_been_hit_recently,
		// Token: 0x04000997 RID: 2455
		have_been_crit_recently,
		// Token: 0x04000998 RID: 2456
		have_crit_recently,
		// Token: 0x04000999 RID: 2457
		have_taken_attack_damage_recently,
		// Token: 0x0400099A RID: 2458
		have_taken_spell_damage_recently,
		// Token: 0x0400099B RID: 2459
		have_used_a_warcry_recently,
		// Token: 0x0400099C RID: 2460
		have_been_savage_hit_recently,
		// Token: 0x0400099D RID: 2461
		have_hit_an_enemy_recently,
		// Token: 0x0400099E RID: 2462
		chronos_statue_life_regen,
		// Token: 0x0400099F RID: 2463
		perandus_gold_spectre_buff,
		// Token: 0x040009A0 RID: 2464
		bane_of_the_loyal,
		// Token: 0x040009A1 RID: 2465
		heart_of_the_gargoyle,
		// Token: 0x040009A2 RID: 2466
		cube_of_absorption,
		// Token: 0x040009A3 RID: 2467
		orb_of_elemental_essence,
		// Token: 0x040009A4 RID: 2468
		rod_of_detonation,
		// Token: 0x040009A5 RID: 2469
		sand_of_eternity,
		// Token: 0x040009A6 RID: 2470
		cogs_of_disruption,
		// Token: 0x040009A7 RID: 2471
		portal_shredder,
		// Token: 0x040009A8 RID: 2472
		perandus_chest_revive_marker,
		// Token: 0x040009A9 RID: 2473
		active_offering,
		// Token: 0x040009AA RID: 2474
		ground_maelstrom_chill,
		// Token: 0x040009AB RID: 2475
		aura_increased_damage_taken,
		// Token: 0x040009AC RID: 2476
		aura_damage_on_movement_skill_use,
		// Token: 0x040009AD RID: 2477
		savage_hit_life_regen,
		// Token: 0x040009AE RID: 2478
		overflowing_chalice,
		// Token: 0x040009AF RID: 2479
		have_killed_a_taunted_enemy_recently,
		// Token: 0x040009B0 RID: 2480
		shavronne_torment_aura,
		// Token: 0x040009B1 RID: 2481
		flask_bonus_flask_charges_gained,
		// Token: 0x040009B2 RID: 2482
		goddess_slow,
		// Token: 0x040009B3 RID: 2483
		have_pierced_recently,
		// Token: 0x040009B4 RID: 2484
		goddess_beam,
		// Token: 0x040009B5 RID: 2485
		have_killed_a_maimed_enemy_recently,
		// Token: 0x040009B6 RID: 2486
		have_taunted_an_enemy_recently,
		// Token: 0x040009B7 RID: 2487
		guardian_additional_block_chance,
		// Token: 0x040009B8 RID: 2488
		guardian_block_cooldown,
		// Token: 0x040009B9 RID: 2489
		blocked_unique_enemy_hit_recently,
		// Token: 0x040009BA RID: 2490
		elementalist_increased_area_of_effect,
		// Token: 0x040009BB RID: 2491
		guardian_increased_elemental_resist,
		// Token: 0x040009BC RID: 2492
		pale_court_invulnerability,
		// Token: 0x040009BD RID: 2493
		pale_court_ghost_invulnerability,
		// Token: 0x040009BE RID: 2494
		intimidated,
		// Token: 0x040009BF RID: 2495
		number_of_corpses_consumed_recently,
		// Token: 0x040009C0 RID: 2496
		flask_cannot_be_stunned,
		// Token: 0x040009C1 RID: 2497
		ascendancy_life_leech,
		// Token: 0x040009C2 RID: 2498
		kiaras_determination,
		// Token: 0x040009C3 RID: 2499
		prophecy_stolen_mods_buff,
		// Token: 0x040009C4 RID: 2500
		summon_specific_monsters_cannot_die,
		// Token: 0x040009C5 RID: 2501
		phoenix_firebomb,
		// Token: 0x040009C6 RID: 2502
		repeated_pulse_cold,
		// Token: 0x040009C7 RID: 2503
		repeated_pulse_lightning,
		// Token: 0x040009C8 RID: 2504
		repeated_pulse_fire,
		// Token: 0x040009C9 RID: 2505
		repeated_pulse_chaos,
		// Token: 0x040009CA RID: 2506
		essence_alternating_buffs_dodge_and_spell_dodge,
		// Token: 0x040009CB RID: 2507
		essence_alternating_buffs_reduced_damage_taken,
		// Token: 0x040009CC RID: 2508
		essence_alternating_buffs_always_crit,
		// Token: 0x040009CD RID: 2509
		flask_elemental_penetration,
		// Token: 0x040009CE RID: 2510
		essence_elemental_damage_taken,
		// Token: 0x040009CF RID: 2511
		essence_burning_ground,
		// Token: 0x040009D0 RID: 2512
		essence_elemental_damage_taken_granted,
		// Token: 0x040009D1 RID: 2513
		curse_immunity,
		// Token: 0x040009D2 RID: 2514
		essence_base_buffs_move_atack_cast_speed,
		// Token: 0x040009D3 RID: 2515
		essence_base_buffs_damage,
		// Token: 0x040009D4 RID: 2516
		essence_base_buffs_crit_immune,
		// Token: 0x040009D5 RID: 2517
		permanent_debuff_on_minion_death,
		// Token: 0x040009D6 RID: 2518
		have_blocked_attack_recently,
		// Token: 0x040009D7 RID: 2519
		phoenix_stacking_debuff,
		// Token: 0x040009D8 RID: 2520
		fire_beam_damage_stacks,
		// Token: 0x040009D9 RID: 2521
		brain_scrambler_shock_effects,
		// Token: 0x040009DA RID: 2522
		razor_unique_increased_burning_damage,
		// Token: 0x040009DB RID: 2523
		shaper_immune,
		// Token: 0x040009DC RID: 2524
		shaper_beam,
		// Token: 0x040009DD RID: 2525
		decay,
		// Token: 0x040009DE RID: 2526
		endurance_frenzy_charge_essence,
		// Token: 0x040009DF RID: 2527
		remnant_of_corruption_aura,
		// Token: 0x040009E0 RID: 2528
		chieftain_enrage_aura,
		// Token: 0x040009E1 RID: 2529
		chieftain_enrage_buff,
		// Token: 0x040009E2 RID: 2530
		rhoa_map_boss_enrage_buff,
		// Token: 0x040009E3 RID: 2531
		monolith_monster_freedom,
		// Token: 0x040009E4 RID: 2532
		essence_random_charge,
		// Token: 0x040009E5 RID: 2533
		essence_charge_max_and_duration,
		// Token: 0x040009E6 RID: 2534
		minotaur_arctrap_debuff,
		// Token: 0x040009E7 RID: 2535
		new_blade_vortex,
		// Token: 0x040009E8 RID: 2536
		new_blade_vortex_effect,
		// Token: 0x040009E9 RID: 2537
		zana_immune_buff,
		// Token: 0x040009EA RID: 2538
		aura_movement_speed_for_spiders,
		// Token: 0x040009EB RID: 2539
		covered_in_spiders,
		// Token: 0x040009EC RID: 2540
		remove_covered_in_spiders,
		// Token: 0x040009ED RID: 2541
		restore,
		// Token: 0x040009EE RID: 2542
		alternating_buffs_item_rarity,
		// Token: 0x040009EF RID: 2543
		base_buffs_item_quantity,
		// Token: 0x040009F0 RID: 2544
		unique_flask_witchfire_brew,
		// Token: 0x040009F1 RID: 2545
		unique_flask_dying_sun,
		// Token: 0x040009F2 RID: 2546
		atlas_lightning_golem_buff,
		// Token: 0x040009F3 RID: 2547
		aura_atlas_gold_pile,
		// Token: 0x040009F4 RID: 2548
		hallowed_ground_boss_invulnerability,
		// Token: 0x040009F5 RID: 2549
		elementalist_all_damage_chills,
		// Token: 0x040009F6 RID: 2550
		elementalist_all_damage_shocks,
		// Token: 0x040009F7 RID: 2551
		elementalist_all_damage_ignites,
		// Token: 0x040009F8 RID: 2552
		elementalist_all_damage_chills_shocks_ignites,
		// Token: 0x040009F9 RID: 2553
		shaper_minions_buff,
		// Token: 0x040009FA RID: 2554
		map_poisoned_while_moving,
		// Token: 0x040009FB RID: 2555
		map_damage_taken_while_stationary,
		// Token: 0x040009FC RID: 2556
		map_damage_taken,
		// Token: 0x040009FD RID: 2557
		ground_haste,
		// Token: 0x040009FE RID: 2558
		damage_taken_on_200_mana_spent,
		// Token: 0x040009FF RID: 2559
		mass_summon_ravens,
		// Token: 0x04000A00 RID: 2560
		damage_and_damage_taken,
		// Token: 0x04000A01 RID: 2561
		map_damage_and_damage_taken_while_stationary,
		// Token: 0x04000A02 RID: 2562
		ground_tar_gold,
		// Token: 0x04000A03 RID: 2563
		strongbox_enrage,
		// Token: 0x04000A04 RID: 2564
		cover_in_ash,
		// Token: 0x04000A05 RID: 2565
		empowering_howl,
		// Token: 0x04000A06 RID: 2566
		new_new_blade_vortex,
		// Token: 0x04000A07 RID: 2567
		have_summoned_golem_in_past_8_seconds,
		// Token: 0x04000A08 RID: 2568
		golem_summoned_in_past_8_seconds,
		// Token: 0x04000A09 RID: 2569
		elementalist_shaper_of_desolation_cooldown,
		// Token: 0x04000A0A RID: 2570
		new_blight,
		// Token: 0x04000A0B RID: 2571
		monster_consume_charges,
		// Token: 0x04000A0C RID: 2572
		player_tencent_asset_lock_bonus,
		// Token: 0x04000A0D RID: 2573
		player_tencent_no_asset_lock,
		// Token: 0x04000A0E RID: 2574
		tencent_tas_lock,
		// Token: 0x04000A0F RID: 2575
		blizzard_enemy,
		// Token: 0x04000A10 RID: 2576
		blizzard_ally,
		// Token: 0x04000A11 RID: 2577
		monster_convert_on_death,
		// Token: 0x04000A12 RID: 2578
		breach_team_warp_buff,
		// Token: 0x04000A13 RID: 2579
		breach_discharge_aura,
		// Token: 0x04000A14 RID: 2580
		breach_discharge,
		// Token: 0x04000A15 RID: 2581
		have_dealt_non_crit_recently,
		// Token: 0x04000A16 RID: 2582
		have_frozen_enemy_recently,
		// Token: 0x04000A17 RID: 2583
		number_of_shocked_enemies_killed_recently,
		// Token: 0x04000A18 RID: 2584
		track_movement,
		// Token: 0x04000A19 RID: 2585
		envy_chaos_damage,
		// Token: 0x04000A1A RID: 2586
		fire_beam_max_damage_stacks,
		// Token: 0x04000A1B RID: 2587
		rhoa_enrage,
		// Token: 0x04000A1C RID: 2588
		fire_beam_resistance_stacks,
		// Token: 0x04000A1D RID: 2589
		abberaths_hooves_display_buff,
		// Token: 0x04000A1E RID: 2590
		spider_god_spiders,
		// Token: 0x04000A1F RID: 2591
		number_of_chests_opened_recently,
		// Token: 0x04000A20 RID: 2592
		have_shattered_recently,
		// Token: 0x04000A21 RID: 2593
		additional_ignite,
		// Token: 0x04000A22 RID: 2594
		unique_flask_the_basics,
		// Token: 0x04000A23 RID: 2595
		classic_prophecy_quantity,
		// Token: 0x04000A24 RID: 2596
		tukohama_shield,
		// Token: 0x04000A25 RID: 2597
		ground_tar_net,
		// Token: 0x04000A26 RID: 2598
		offering_blood,
		// Token: 0x04000A27 RID: 2599
		have_blocked_spell_recently,
		// Token: 0x04000A28 RID: 2600
		have_used_a_fire_skill_recently,
		// Token: 0x04000A29 RID: 2601
		brutus_empowered,
		// Token: 0x04000A2A RID: 2602
		unique_victarios_flight_movement_velocity,
		// Token: 0x04000A2B RID: 2603
		intimidated_aura,
		// Token: 0x04000A2C RID: 2604
		beyond_host,
		// Token: 0x04000A2D RID: 2605
		brine_king_tide,
		// Token: 0x04000A2E RID: 2606
		energy_shield_has_started_recharging_recently,
		// Token: 0x04000A2F RID: 2607
		ground_devouring_darkness,
		// Token: 0x04000A30 RID: 2608
		have_stopped_taking_damage_over_time_recently,
		// Token: 0x04000A31 RID: 2609
		have_been_frozen_recently,
		// Token: 0x04000A32 RID: 2610
		have_been_stunned_recently,
		// Token: 0x04000A33 RID: 2611
		tukohama_god_stationary_buff,
		// Token: 0x04000A34 RID: 2612
		ryslatha_god_life_flask_charges_gain,
		// Token: 0x04000A35 RID: 2613
		tangmazu_god_curses_have_no_effect_on_you_cooldown,
		// Token: 0x04000A36 RID: 2614
		curses_have_no_effect_on_you,
		// Token: 0x04000A37 RID: 2615
		infested,
		// Token: 0x04000A38 RID: 2616
		fearless,
		// Token: 0x04000A39 RID: 2617
		frog_orb_aura,
		// Token: 0x04000A3A RID: 2618
		frog_orb_aura_minions,
		// Token: 0x04000A3B RID: 2619
		water_orb_aura,
		// Token: 0x04000A3C RID: 2620
		stolen_mods_inspired_learning,
		// Token: 0x04000A3D RID: 2621
		stolen_mods_leaguestone,
		// Token: 0x04000A3E RID: 2622
		abberath_minion_buff,
		// Token: 0x04000A3F RID: 2623
		herald_of_ash_burning,
		// Token: 0x04000A40 RID: 2624
		number_of_enemies_shocked_recently,
		// Token: 0x04000A41 RID: 2625
		kitava_swipe_debuff,
		// Token: 0x04000A42 RID: 2626
		despair_bear_slow,
		// Token: 0x04000A43 RID: 2627
		have_used_movement_skill_recently,
		// Token: 0x04000A44 RID: 2628
		ascendant_chaos_resistance,
		// Token: 0x04000A45 RID: 2629
		ascendant_block_chance,
		// Token: 0x04000A46 RID: 2630
		ascendant_attack_cast_movement_speed,
		// Token: 0x04000A47 RID: 2631
		have_placed_trap_or_mine_recently,
		// Token: 0x04000A48 RID: 2632
		ground_despair_geyser,
		// Token: 0x04000A49 RID: 2633
		support_maimed_enemies_damage_taken,
		// Token: 0x04000A4A RID: 2634
		have_used_a_cold_skill_recently,
		// Token: 0x04000A4B RID: 2635
		attack_speed_debuff_from_hitting_enemy_recently,
		// Token: 0x04000A4C RID: 2636
		yugul_hidden_monster,
		// Token: 0x04000A4D RID: 2637
		ground_maelstrom_chill_lunaris,
		// Token: 0x04000A4E RID: 2638
		silver_orb_aggressive,
		// Token: 0x04000A4F RID: 2639
		ground_sandstorm,
		// Token: 0x04000A50 RID: 2640
		number_of_nearby_enemies,
		// Token: 0x04000A51 RID: 2641
		ralakesh_buff,
		// Token: 0x04000A52 RID: 2642
		plague,
		// Token: 0x04000A53 RID: 2643
		accelerate,
		// Token: 0x04000A54 RID: 2644
		arcane_surge,
		// Token: 0x04000A55 RID: 2645
		mana_gained_from_hit_damage,
		// Token: 0x04000A56 RID: 2646
		lightning_thorns_cold,
		// Token: 0x04000A57 RID: 2647
		blight_hinder_chaos_damage_taken,
		// Token: 0x04000A58 RID: 2648
		moontouched_buff,
		// Token: 0x04000A59 RID: 2649
		innervate_support,
		// Token: 0x04000A5A RID: 2650
		blackguardzombie_enrage,
		// Token: 0x04000A5B RID: 2651
		basilisk_slow,
		// Token: 0x04000A5C RID: 2652
		basilisk_gaze,
		// Token: 0x04000A5D RID: 2653
		bleeding_stack,
		// Token: 0x04000A5E RID: 2654
		ruthless_big_hit_counter,
		// Token: 0x04000A5F RID: 2655
		boulderdash_enrage,
		// Token: 0x04000A60 RID: 2656
		general_adus_supercharged,
		// Token: 0x04000A61 RID: 2657
		monster_temporary_additional_projectiles,
		// Token: 0x04000A62 RID: 2658
		intimidated_aura_rhoa,
		// Token: 0x04000A63 RID: 2659
		arcane_surge_mana_spent,
		// Token: 0x04000A64 RID: 2660
		darktongue_kiss,
		// Token: 0x04000A65 RID: 2661
		harbinger_minion_new,
		// Token: 0x04000A66 RID: 2662
		have_blocked_a_stun_recently,
		// Token: 0x04000A67 RID: 2663
		void_gaze,
		// Token: 0x04000A68 RID: 2664
		charged_dash_chance_to_dodge,
		// Token: 0x04000A69 RID: 2665
		kitava_heart_damage_taken,
		// Token: 0x04000A6A RID: 2666
		abyss_monsters_damage_taken,
		// Token: 0x04000A6B RID: 2667
		pantheon_brine_king_stun_immunity,
		// Token: 0x04000A6C RID: 2668
		power_charge_on_mana_spent,
		// Token: 0x04000A6D RID: 2669
		occultist_power_charge_on_mana_spent,
		// Token: 0x04000A6E RID: 2670
		caustic_cloud_trail,
		// Token: 0x04000A6F RID: 2671
		quicksand_aura,
		// Token: 0x04000A70 RID: 2672
		quicksand_buff,
		// Token: 0x04000A71 RID: 2673
		thaumaturgy_rotation,
		// Token: 0x04000A72 RID: 2674
		ankh_of_eternity_enrage,
		// Token: 0x04000A73 RID: 2675
		gain_random_charges_while_stationary,
		// Token: 0x04000A74 RID: 2676
		quicksand_display_buff,
		// Token: 0x04000A75 RID: 2677
		unique_flask_gorgon_poison,
		// Token: 0x04000A76 RID: 2678
		spectral_spinning_weapon,
		// Token: 0x04000A77 RID: 2679
		unique_flask_shakari_increased_speed,
		// Token: 0x04000A78 RID: 2680
		unique_flask_shakari_reduced_speed_per_second,
		// Token: 0x04000A79 RID: 2681
		have_been_damaged_by_hit_recently,
		// Token: 0x04000A7A RID: 2682
		have_used_a_minion_skill_recently,
		// Token: 0x04000A7B RID: 2683
		has_player_minion_been_killed_recently,
		// Token: 0x04000A7C RID: 2684
		minion_has_killed_enemy_recently,
		// Token: 0x04000A7D RID: 2685
		fire_impurity_buff,
		// Token: 0x04000A7E RID: 2686
		cold_impurity_buff,
		// Token: 0x04000A7F RID: 2687
		lightning_impurity_buff,
		// Token: 0x04000A80 RID: 2688
		storm_barrier_support,
		// Token: 0x04000A81 RID: 2689
		critical_strike_chance_on_mana_spent,
		// Token: 0x04000A82 RID: 2690
		critical_strike_chance_unique,
		// Token: 0x04000A83 RID: 2691
		her_embrace_unique,
		// Token: 0x04000A84 RID: 2692
		grasping_vines_aura,
		// Token: 0x04000A85 RID: 2693
		grasping_vines_buff,
		// Token: 0x04000A86 RID: 2694
		disable_light,
		// Token: 0x04000A87 RID: 2695
		tentacle_fiend_aura,
		// Token: 0x04000A88 RID: 2696
		tentacle_fiend_aura_monster,
		// Token: 0x04000A89 RID: 2697
		elder_siphon_debuff,
		// Token: 0x04000A8A RID: 2698
		elder_siphon_buff,
		// Token: 0x04000A8B RID: 2699
		elder_siphon_slow,
		// Token: 0x04000A8C RID: 2700
		elder_siphon_immobilise,
		// Token: 0x04000A8D RID: 2701
		ailments_types_grant_damage_taken_child_buff_shock,
		// Token: 0x04000A8E RID: 2702
		ailments_types_grant_damage_taken_child_buff_freeze,
		// Token: 0x04000A8F RID: 2703
		ailments_types_grant_damage_taken_child_buff_chill,
		// Token: 0x04000A90 RID: 2704
		ailments_types_grant_damage_taken_child_buff_ignite,
		// Token: 0x04000A91 RID: 2705
		ailments_types_grant_damage_taken_child_buff_bleeding,
		// Token: 0x04000A92 RID: 2706
		ailments_types_grant_damage_taken_child_buff_poison,
		// Token: 0x04000A93 RID: 2707
		stolen_mods_elder_stat,
		// Token: 0x04000A94 RID: 2708
		reduced_evasion_from_hit,
		// Token: 0x04000A95 RID: 2709
		iron_reflexes_every_16_sec,
		// Token: 0x04000A96 RID: 2710
		iron_reflexes_from_unique,
		// Token: 0x04000A97 RID: 2711
		have_stunned_an_enemy_recently,
		// Token: 0x04000A98 RID: 2712
		gain_endurance_charges_while_stationary,
		// Token: 0x04000A99 RID: 2713
		death_walk_display_buff,
		// Token: 0x04000A9A RID: 2714
		mother_of_flames_daemon_debuff,
		// Token: 0x04000A9B RID: 2715
		elemental_overload_every_16_sec,
		// Token: 0x04000A9C RID: 2716
		elemental_overload_from_unique,
		// Token: 0x04000A9D RID: 2717
		avatar_of_fire_every_8_sec,
		// Token: 0x04000A9E RID: 2718
		avatar_of_fire_from_unique,
		// Token: 0x04000A9F RID: 2719
		physical_reflect_mortar_mod,
		// Token: 0x04000AA0 RID: 2720
		elemental_reflect_mortar_mod,
		// Token: 0x04000AA1 RID: 2721
		disable_rarity_epk,
		// Token: 0x04000AA2 RID: 2722
		curse_chaos_weakness,
		// Token: 0x04000AA3 RID: 2723
		mirage_archer_visual_buff,
		// Token: 0x04000AA4 RID: 2724
		shade_form,
		// Token: 0x04000AA5 RID: 2725
		lich_crystal_damage_reduction,
		// Token: 0x04000AA6 RID: 2726
		petrification_statue_gaze,
		// Token: 0x04000AA7 RID: 2727
		elder_ground_spores,
		// Token: 0x04000AA8 RID: 2728
		kitava_visual_display_buff,
		// Token: 0x04000AA9 RID: 2729
		elder_tentacle_portal_no_revive,
		// Token: 0x04000AAA RID: 2730
		minions_no_drops_or_experience,
		// Token: 0x04000AAB RID: 2731
		zana_dont_hurt_me,
		// Token: 0x04000AAC RID: 2732
		skill_interruption,
		// Token: 0x04000AAD RID: 2733
		uber_elder_immune_buff,
		// Token: 0x04000AAE RID: 2734
		uber_shaper_immune_buff,
		// Token: 0x04000AAF RID: 2735
		total_mana_spent_recently,
		// Token: 0x04000AB0 RID: 2736
		have_used_a_skill_recently,
		// Token: 0x04000AB1 RID: 2737
		gain_void_arrows,
		// Token: 0x04000AB2 RID: 2738
		temporal_anomaly,
		// Token: 0x04000AB3 RID: 2739
		bestiary_monster_phase_in,
		// Token: 0x04000AB4 RID: 2740
		intimidating_cry,
		// Token: 0x04000AB5 RID: 2741
		cat_aspect,
		// Token: 0x04000AB6 RID: 2742
		cats_stealth,
		// Token: 0x04000AB7 RID: 2743
		cats_agility,
		// Token: 0x04000AB8 RID: 2744
		bird_aspect,
		// Token: 0x04000AB9 RID: 2745
		bird_aspect_double_damage,
		// Token: 0x04000ABA RID: 2746
		bird_aspect_movement_speed,
		// Token: 0x04000ABB RID: 2747
		spider_aspect,
		// Token: 0x04000ABC RID: 2748
		spider_aspect_webs,
		// Token: 0x04000ABD RID: 2749
		have_killed_cursed_enemy_recently,
		// Token: 0x04000ABE RID: 2750
		flask_life_gain_on_skill_use_over_4_seconds,
		// Token: 0x04000ABF RID: 2751
		crab_aspect,
		// Token: 0x04000AC0 RID: 2752
		crab_aspect_stacking_buff,
		// Token: 0x04000AC1 RID: 2753
		fire_projectile_retaliation,
		// Token: 0x04000AC2 RID: 2754
		fire_projectile_retaliation_charging,
		// Token: 0x04000AC3 RID: 2755
		physical_projectile_retaliation,
		// Token: 0x04000AC4 RID: 2756
		physical_projectile_retaliation_charging,
		// Token: 0x04000AC5 RID: 2757
		master_buff_treasure_hunter,
		// Token: 0x04000AC6 RID: 2758
		godmode_ghost,
		// Token: 0x04000AC7 RID: 2759
		best_crab_roar,
		// Token: 0x04000AC8 RID: 2760
		vilenta_reflection_beam_degen,
		// Token: 0x04000AC9 RID: 2761
		nemesis_vines,
		// Token: 0x04000ACA RID: 2762
		nemesis_vines_large,
		// Token: 0x04000ACB RID: 2763
		number_of_crab_charges_lost_recently,
		// Token: 0x04000ACC RID: 2764
		rage,
		// Token: 0x04000ACD RID: 2765
		bestiary_harpoon_slow,
		// Token: 0x04000ACE RID: 2766
		bestiary_tiger_teleport,
		// Token: 0x04000ACF RID: 2767
		bestiary_spider_web,
		// Token: 0x04000AD0 RID: 2768
		lightning_clone_retaliation,
		// Token: 0x04000AD1 RID: 2769
		lightning_clone_minion,
		// Token: 0x04000AD2 RID: 2770
		elementalist_pendulum_rotation,
		// Token: 0x04000AD3 RID: 2771
		elementalist_new_increased_elemental_damage,
		// Token: 0x04000AD4 RID: 2772
		elementalist_new_increased_aoe,
		// Token: 0x04000AD5 RID: 2773
		gain_endurance_charges_if_hit_recently,
		// Token: 0x04000AD6 RID: 2774
		have_taken_fire_damage_from_a_hit_recently,
		// Token: 0x04000AD7 RID: 2775
		chieftain_physical_as_fire_cycle,
		// Token: 0x04000AD8 RID: 2776
		chieftain_physical_as_fire_for_3_sec,
		// Token: 0x04000AD9 RID: 2777
		have_crit_in_past_8_seconds,
		// Token: 0x04000ADA RID: 2778
		number_of_traps_triggered_recently,
		// Token: 0x04000ADB RID: 2779
		number_of_mines_detonated_recently,
		// Token: 0x04000ADC RID: 2780
		additional_block_if_attacked_recently,
		// Token: 0x04000ADD RID: 2781
		additional_spell_block_if_have_cast_spell_recently,
		// Token: 0x04000ADE RID: 2782
		capture_monster_trapped,
		// Token: 0x04000ADF RID: 2783
		capture_monster_enraged,
		// Token: 0x04000AE0 RID: 2784
		capture_monster_captured,
		// Token: 0x04000AE1 RID: 2785
		capture_monster_disappearing,
		// Token: 0x04000AE2 RID: 2786
		cold_beam_retaliation,
		// Token: 0x04000AE3 RID: 2787
		juggernaut_phys_damage_prevented_as_life_regen,
		// Token: 0x04000AE4 RID: 2788
		animated_guardian_defence_tracking,
		// Token: 0x04000AE5 RID: 2789
		recent_rage_tracker,
		// Token: 0x04000AE6 RID: 2790
		cannot_evade_attacks,
		// Token: 0x04000AE7 RID: 2791
		adrenaline,
		// Token: 0x04000AE8 RID: 2792
		malediction,
		// Token: 0x04000AE9 RID: 2793
		spider_aspect_webs_resistance_and_damage,
		// Token: 0x04000AEA RID: 2794
		bestiary_boss_growing_damage_aoe,
		// Token: 0x04000AEB RID: 2795
		tailwind,
		// Token: 0x04000AEC RID: 2796
		tailwind_stacking_effectiveness,
		// Token: 0x04000AED RID: 2797
		block_chance_per_hit_blocked_past_10_sec,
		// Token: 0x04000AEE RID: 2798
		blinding_aura,
		// Token: 0x04000AEF RID: 2799
		assassin_poison_duration,
		// Token: 0x04000AF0 RID: 2800
		bestiary_cocoon,
		// Token: 0x04000AF1 RID: 2801
		bestiary_spider_hallucinate,
		// Token: 0x04000AF2 RID: 2802
		monster_menagerie_buff,
		// Token: 0x04000AF3 RID: 2803
		bestiary_agile_rhex_alternator,
		// Token: 0x04000AF4 RID: 2804
		bestiary_agile_rhex_aura1,
		// Token: 0x04000AF5 RID: 2805
		bestiary_agile_rhex_aura2,
		// Token: 0x04000AF6 RID: 2806
		bestiary_regen_ursa_alternator,
		// Token: 0x04000AF7 RID: 2807
		bestiary_regen_ursa_aura1,
		// Token: 0x04000AF8 RID: 2808
		bestiary_regen_ursa_aura2,
		// Token: 0x04000AF9 RID: 2809
		bestiary_fast_lynx_alternator,
		// Token: 0x04000AFA RID: 2810
		bestiary_fast_lynx_aura1,
		// Token: 0x04000AFB RID: 2811
		bestiary_fast_lynx_aura2,
		// Token: 0x04000AFC RID: 2812
		bestiary_tank_crab_aura,
		// Token: 0x04000AFD RID: 2813
		bestiary_cold_squid_aura,
		// Token: 0x04000AFE RID: 2814
		bestiary_poison_spider_aura,
		// Token: 0x04000AFF RID: 2815
		bestiary_tiger_boss_aura1,
		// Token: 0x04000B00 RID: 2816
		elemental_warding_buff,
		// Token: 0x04000B01 RID: 2817
		bestiary_legendary_enrage,
		// Token: 0x04000B02 RID: 2818
		royale_pain
	}
}
