using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 角色进阶时，更换技能id message
 */
public class ResCharacterSkillsMessage : Message 
{
	//角色id
	int _characterId;	
	//角色进阶后拥有的技能id
	List<SkillInfo> _skillInfo = new List<SkillInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//角色进阶后拥有的技能id
		SerializeUtils.WriteShort(stream, (short)_skillInfo.Count);

		foreach (var element in _skillInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//角色进阶后拥有的技能id
		int _skillInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _skillInfo_length; ++i) 
		{
			_skillInfo.Add(SerializeUtils.ReadBean<SkillInfo>(stream));
		}
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * get 角色进阶后拥有的技能id
	 * @return 
	 */
	public List<SkillInfo> GetSkillInfo()
	{
		return _skillInfo;
	}
	
	/**
	 * set 角色进阶后拥有的技能id
	 */
	public void SetSkillInfo(List<SkillInfo> skillInfo)
	{
		_skillInfo = skillInfo;
	}
	
	
	public override int GetId() 
	{
		return 208101;
	}
}