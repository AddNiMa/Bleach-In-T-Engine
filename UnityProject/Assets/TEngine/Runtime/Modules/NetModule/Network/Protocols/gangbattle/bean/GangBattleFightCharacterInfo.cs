using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战参战玩家角色信息
 */
public class GangBattleFightCharacterInfo : IMessageSerialize 
{
	//角色id
	int _characterId;	
	//角色阶级
	int _characterStageLevel;	
	//角色成长等级
	int _growthLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//角色阶级
		SerializeUtils.WriteInt(stream, _characterStageLevel);
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//角色阶级
		_characterStageLevel = SerializeUtils.ReadInt(stream);
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
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
	 * 角色阶级
	 */
	public int CharacterStageLevel
	{
		set { _characterStageLevel = value; }
	    get { return _characterStageLevel; }
	}
	
	/**
	 * 角色成长等级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
}