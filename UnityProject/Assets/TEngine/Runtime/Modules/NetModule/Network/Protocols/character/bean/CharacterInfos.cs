using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 拥有的角色列表信息
 */
public class CharacterInfos : IMessageSerialize 
{
	//角色Id
	int _charId;	
	//角色阶级
	int _stageLevel;	
	//角色成长等级
	int _growthLevel;	
	//装备信息
	List<EquipInfo> _equipInfo = new List<EquipInfo>();
	//技能信息
	List<SkillInfo> _skillInfo = new List<SkillInfo>();
	//灵魂能力信息
	List<SoulAbilityInfo> _soulAbilityInfos = new List<SoulAbilityInfo>();
	//特训buff信息
	List<SpecialTrainingBuffInfo> _specialTrainingBuffInfos = new List<SpecialTrainingBuffInfo>();
    //静血装id
    int _staticBloodId;
    //崩玉之力id
    int _hogyoKuPowerId;
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色Id
		SerializeUtils.WriteInt(stream, _charId);
		//角色阶级
		SerializeUtils.WriteInt(stream, _stageLevel);
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//装备信息
		SerializeUtils.WriteShort(stream, (short)_equipInfo.Count);

		foreach (var element in _equipInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//技能信息
		SerializeUtils.WriteShort(stream, (short)_skillInfo.Count);

		foreach (var element in _skillInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//灵魂能力信息
		SerializeUtils.WriteShort(stream, (short)_soulAbilityInfos.Count);

		foreach (var element in _soulAbilityInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//特训buff信息
		SerializeUtils.WriteShort(stream, (short)_specialTrainingBuffInfos.Count);

		foreach (var element in _specialTrainingBuffInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
        //静血装id
        SerializeUtils.WriteInt(stream, _staticBloodId);
        //崩玉之力id
        SerializeUtils.WriteInt(stream, _hogyoKuPowerId);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色Id
		_charId = SerializeUtils.ReadInt(stream);
		//角色阶级
		_stageLevel = SerializeUtils.ReadInt(stream);
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//装备信息
		int _equipInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _equipInfo_length; ++i) 
		{
			_equipInfo.Add(SerializeUtils.ReadBean<EquipInfo>(stream));
		}
		//技能信息
		int _skillInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _skillInfo_length; ++i) 
		{
			_skillInfo.Add(SerializeUtils.ReadBean<SkillInfo>(stream));
		}
		//灵魂能力信息
		int _soulAbilityInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulAbilityInfos_length; ++i) 
		{
			_soulAbilityInfos.Add(SerializeUtils.ReadBean<SoulAbilityInfo>(stream));
		}
		//特训buff信息
		int _specialTrainingBuffInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _specialTrainingBuffInfos_length; ++i) 
		{
			_specialTrainingBuffInfos.Add(SerializeUtils.ReadBean<SpecialTrainingBuffInfo>(stream));
		}
        //静血装id
        _staticBloodId = SerializeUtils.ReadInt(stream);
        //崩玉之力id
        _hogyoKuPowerId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色Id
	 */
	public int CharId
	{
		set { _charId = value; }
	    get { return _charId; }
	}
	
	/**
	 * 角色阶级
	 */
	public int StageLevel
	{
		set { _stageLevel = value; }
	    get { return _stageLevel; }
	}
	
	/**
	 * 角色成长等级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
	/**
	 * get 装备信息
	 * @return 
	 */
	public List<EquipInfo> GetEquipInfo()
	{
		return _equipInfo;
	}
	
	/**
	 * set 装备信息
	 */
	public void SetEquipInfo(List<EquipInfo> equipInfo)
	{
		_equipInfo = equipInfo;
	}
	
	/**
	 * get 技能信息
	 * @return 
	 */
	public List<SkillInfo> GetSkillInfo()
	{
		return _skillInfo;
	}
	
	/**
	 * set 技能信息
	 */
	public void SetSkillInfo(List<SkillInfo> skillInfo)
	{
		_skillInfo = skillInfo;
	}
	
	/**
	 * get 灵魂能力信息
	 * @return 
	 */
	public List<SoulAbilityInfo> GetSoulAbilityInfos()
	{
		return _soulAbilityInfos;
	}
	
	/**
	 * set 灵魂能力信息
	 */
	public void SetSoulAbilityInfos(List<SoulAbilityInfo> soulAbilityInfos)
	{
		_soulAbilityInfos = soulAbilityInfos;
	}
	
	/**
	 * get 特训buff信息
	 * @return 
	 */
	public List<SpecialTrainingBuffInfo> GetSpecialTrainingBuffInfos()
	{
		return _specialTrainingBuffInfos;
	}
	
	/**
	 * set 特训buff信息
	 */
	public void SetSpecialTrainingBuffInfos(List<SpecialTrainingBuffInfo> specialTrainingBuffInfos)
	{
		_specialTrainingBuffInfos = specialTrainingBuffInfos;
	}
    /**
 * 静血装id
 */
    public int StaticBloodId
    {
        set { _staticBloodId = value; }
        get { return _staticBloodId; }
    }
    /**
 * 崩玉之力id
 */
    public int HogyoKuPowerId
    {
        set { _hogyoKuPowerId = value; }
        get { return _hogyoKuPowerId; }
    }
}