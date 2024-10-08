using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵魂试炼对手信息
 */
public class SoulTrialOppenentInfo : IMessageSerialize 
{
	//对手名字
	string _playerName;	
	//对手等级
	int _playerLevel;	
	//对手角色id
	int _characterId;	
	//对手阶级
	int _stageLevel;	
	//角色成长等级
	int _growthLevel;	
	//对手战斗力
	int _fighting;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//对手名字
		SerializeUtils.WriteString(stream, _playerName);
		//对手等级
		SerializeUtils.WriteInt(stream, _playerLevel);
		//对手角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//对手阶级
		SerializeUtils.WriteInt(stream, _stageLevel);
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//对手战斗力
		SerializeUtils.WriteInt(stream, _fighting);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//对手名字
		_playerName = SerializeUtils.ReadString(stream);
		//对手等级
		_playerLevel = SerializeUtils.ReadInt(stream);
		//对手角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//对手阶级
		_stageLevel = SerializeUtils.ReadInt(stream);
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//对手战斗力
		_fighting = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 对手名字
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 对手等级
	 */
	public int PlayerLevel
	{
		set { _playerLevel = value; }
	    get { return _playerLevel; }
	}
	
	/**
	 * 对手角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 对手阶级
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
	 * 对手战斗力
	 */
	public int Fighting
	{
		set { _fighting = value; }
	    get { return _fighting; }
	}
	
}