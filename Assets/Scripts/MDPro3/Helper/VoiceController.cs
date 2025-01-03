

namespace MDPro3
{
    public class VoiceController
    {
        public enum Category
        {
            Null = 0,
            BeforeDuel = 1,
            DuelStart = 2,
            TurnStart = 3,
            Draw = 4,
            DestinyDraw = 5,
            BeforeCardEffect = 6,
            CardEffect = 7,
            MainMagicTrap = 8,
            MainMonsterEffect = 9,
            BeforeSummon = 10,
            Summon = 11,
            None = 12,
            MainMonsterSummon = 13,
            BattleStart = 14,
            BeforeAttackNormal = 15,
            BeforeAttackFinish = 16,
            Attack = 17,
            DirectAttack = 18,
            MainMonsterAttack = 19,
            CardSet = 20,
            TurnEnd = 21,
            Damage = 22,
            FinishDamage = 23,
            CostDamage = 24,
            BigDamage = 25,
            AfterDamage = 26,
            AfterBigDamage = 27,
            Win = 28,
            Lose = 29,
            Taunt = 30,
            Surprise = 31,
            Title = 32,
            Skill = 33,
            Chat = 34,
            CharaChange = 35,
            SwitchToPartner = 36,
            BeforeMainSummon = 37,
            RidingDuelStart = 38,
            CoinTossOfMagicTrap = 39,
            CoinTossOfMonster = 40,
            BeforeDimensionDuel = 41,
            DimensionDuelStart = 42,
            Transformation = 43,
            ActionDuelStart = 44,
            ActionCard = 45,
            BeforeMainReincarnationSummon = 46,
            MainMonsterReincarnationSummon = 47,
            RushDuelStart = 48,
            RidingRushDuelStart = 49
        }

        public enum SummonSub
        {
            Normal = 0,
            Guard = 1,
            Special = 2,
            Release = 3,
            Advance = 4,
            Fusion = 5,
            Ritual = 6,
            Sync = 7,
            Xyz = 8,
            Pendulum = 9,
            Link = 10,
            Maximum = 11,
            RushFusion = 12
        }

        public enum CardSetSub
        {
            MagicTrap = 0,
            Monster = 1
        }

        public enum CardEffectSub
        {
            FromHand = 0,
            Magic = 1,
            QuickPlayMagic = 2,
            PermanentMagic = 3,
            EquipMagic = 4,
            RitualMagic = 5,
            Trap = 6,
            PermanentTrap = 7,
            CounterTrap = 8,
            Reverse = 9,
            MonsterEffect = 10,
            FieldMagic = 11,
            General = 12,
            PendulumScale = 13,
            PendulumEffect = 14
        }

        public enum MainMonsterSub
        {
            Default = 0,
            Maximum = 1
        }

        public enum RushDuelStartSub
        {
            Beginning = 0,
            Main = 1,
            Max = 2
        }

        public enum NormalEffectState
        {
            Default = 0,
            FromHand = 1,
            Reverse = 2,
            PendulumScale = 3
        }
    }
}
