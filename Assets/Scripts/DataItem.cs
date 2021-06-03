﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelItem
{
    public string id;
    public string interval;//出兵间隔
    public float max;//最大出兵数量
    public float suol_max;//小兵的生命数量上限
    public string soldier_id;//小兵类型
    public string soldier_lv;//小兵等级
    public string soldier_1;//
    public string soldier_2;
    public string soldier_3;
    public string soldier_4;
    public string soldier_5;
    public string soldier_6;
    public string soldier_7;
    public string boos;//Boss的id和等级
    public string mapId;
    public string weatherID;
    public float minssion_diamond;
    public string timeAngle;
    public string lightcolor;
    public string skycolor;
}

[System.Serializable]
public class BuffItem
{
    public string id;
    public float type;
    public string des;
    public float time;
    public float probability;
    public float boosOdds;
}

[System.Serializable]
public class ShooterItem
{
    public string id;//
    public float type;//
    public string realname;//名字
    public float atk_distance;//攻击距离触发区间
    public float atk_type;//当前类型的伤害数值
    public float atk_growth_type;//
    public float atk_attach;//伤害数值
    public float atk_growth_attach;
    public float att_interval;//攻击频率
    public float unlock_diamond;//解锁需要的钻石
    public float up_star;
    public float up_diamond;
    public float unlock_level;//解锁需要的关卡
    public float up_diamond_growth;//升星的升级系数
    public float drop_shooter;//塔的生成几率
    public float bullet_type;//伤害类型
    public float num;//单次攻击的子弹数量
    public string param;//特殊状态攻击
    public float speed;//速度
    public string range;//伤害范围
    public float dam_max;//单次攻击的伤人数量
    public string buff;//buffID
    public string explain;//描述
    public float starLevel;
    public string ip_name;
}

[System.Serializable]
public class EnemyItem
{
    public string id;//id
    public string realName;//名字
    public float hp;//基础生命
    public float hp_growth;//升级生命系数
    public float def;//物理防御
    public float def_growth;//升级防御系数
    public float def_spe;//特殊防御
    public float def_spe_type;//特殊防御类型
    public float def_spe_growth;//升级特殊防御系数
    public float speed;//速度
    public float soul;//灵魂
    public float dropG;//掉落金币基础
    public float jump_power;
    public string jump_interval;
    public float jump_speed;
    public float speed_add_max;
}

[System.Serializable]
public class MissionItem
{
    public string id;
    public float type_mission;
    public float type_reward;
    public float need;
    public float reward;
    public float reward_growth;
    public float need_growth;
    public string icon_name;
    public string description;
    public string resistance;
}

[System.Serializable]
public class SourceItem
{
    //23-40动物声音
    public string source;
}

[System.Serializable]
public class SkillItem
{
    public string id;
    public string realname;
    public float unlock_level;
    public float up_star;
    public float up__star_growth;
    public float unlock_diamond;
    public float up_diamond;
    public float up_diamond_growth;
    public float forcibly_unlock_diamond;
    public string dam_max;
    public float num;
    public float bullet_type;
    public string range;
    public float atk_percentage;
    public float atk_num;
    public float atk_growth;
    public string param;
    public string buff_id;
    public float att_interval;
    public float cost;
    public string des;
    public float drop_skill;
    public float boss_atk_percentage;
    public float type;
    public string ip_name;
}

[System.Serializable]
public class DetailsItem
{
    public string id;
    public string realname;
    public string des;
    public string ip_name;
}


[System.Serializable]
public class LanguageItem
{
    public string key;
    public string value;
}