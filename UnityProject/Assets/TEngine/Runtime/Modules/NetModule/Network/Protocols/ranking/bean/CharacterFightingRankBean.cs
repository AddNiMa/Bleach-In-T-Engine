using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 最强角色榜
 */
public class CharacterFightingRankBean : IMessageSerialize 
{
	//角色id
	int _characterId;	
	//角色阶级
	int _stageLevel;	
	//角色成长等级
	int _growthLevel;	
	//战斗力
	int _fighting;	
	//玩家id
	long _playerId;	
	//玩家名
	string _playerName;	
	//番队名
	string _gangName;	
	//VIP等级
	int _vipLevel;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//角色阶级
		SerializeUtils.WriteInt(stream, _stageLevel);
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//战斗力
		SerializeUtils.WriteInt(stream, _fighting);
		//玩家id
		SerializeUtils.WriteLong(stream, _playerId);
		//玩家名
		SerializeUtils.WriteString(stream, _playerName);
		//番队名
		SerializeUtils.WriteString(stream, _gangName);
		//VIP等级
		SerializeUtils.WriteInt(stream, _vipLevel);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//角色阶级
		_stageLevel = SerializeUtils.ReadInt(stream);
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//战斗力
		_fighting = SerializeUtils.ReadInt(stream);
		//玩家id
		_playerId = SerializeUtils.ReadLong(stream);
		//玩家名
		_playerName = SerializeUtils.ReadString(stream);
		//番队名
		_gangName = SerializeUtils.ReadString(stream);
		//VIP等级
		_vipLevel = SerializeUtils.ReadInt(stream);
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
	 * 战斗力
	 */
	public int Fighting
	{
		set { _fighting = value; }
	    get { return _fighting; }
	}
	
	/**
	 * 玩家id
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 玩家名
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 番队名
	 */
	public string GangName
	{
		set { _gangName = value; }
	    get { return _gangName; }
	}
	
	/**
	 * VIP等级
	 */
	public int VipLevel
	{
		set { _vipLevel = value; }
	    get { return _vipLevel; }
	}
	
}