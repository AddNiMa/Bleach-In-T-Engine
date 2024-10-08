using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵魂试炼信息
 */
public class SoulTrialInfo : IMessageSerialize 
{
	//灵魂试炼已通过的最大id
	int _maxId;	
	//灵魂试炼可重新开始次数
	int _count;	
	//是否已领取单关奖励,0:未领取， 1：已领取
	int _reward;	
	//是否清除对手信息，0:不清除， 1：清除
	int _clearEnemy;	
	//该轮是否已经扫荡过[0:还没有扫荡过,1:已经扫荡过]
	int _moped;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//灵魂试炼已通过的最大id
		SerializeUtils.WriteInt(stream, _maxId);
		//灵魂试炼可重新开始次数
		SerializeUtils.WriteInt(stream, _count);
		//是否已领取单关奖励,0:未领取， 1：已领取
		SerializeUtils.WriteInt(stream, _reward);
		//是否清除对手信息，0:不清除， 1：清除
		SerializeUtils.WriteInt(stream, _clearEnemy);
		//该轮是否已经扫荡过[0:还没有扫荡过,1:已经扫荡过]
		SerializeUtils.WriteInt(stream, _moped);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//灵魂试炼已通过的最大id
		_maxId = SerializeUtils.ReadInt(stream);
		//灵魂试炼可重新开始次数
		_count = SerializeUtils.ReadInt(stream);
		//是否已领取单关奖励,0:未领取， 1：已领取
		_reward = SerializeUtils.ReadInt(stream);
		//是否清除对手信息，0:不清除， 1：清除
		_clearEnemy = SerializeUtils.ReadInt(stream);
		//该轮是否已经扫荡过[0:还没有扫荡过,1:已经扫荡过]
		_moped = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 灵魂试炼已通过的最大id
	 */
	public int MaxId
	{
		set { _maxId = value; }
	    get { return _maxId; }
	}
	
	/**
	 * 灵魂试炼可重新开始次数
	 */
	public int Count
	{
		set { _count = value; }
	    get { return _count; }
	}
	
	/**
	 * 是否已领取单关奖励,0:未领取， 1：已领取
	 */
	public int Reward
	{
		set { _reward = value; }
	    get { return _reward; }
	}
	
	/**
	 * 是否清除对手信息，0:不清除， 1：清除
	 */
	public int ClearEnemy
	{
		set { _clearEnemy = value; }
	    get { return _clearEnemy; }
	}
	
	/**
	 * 该轮是否已经扫荡过[0:还没有扫荡过,1:已经扫荡过]
	 */
	public int Moped
	{
		set { _moped = value; }
	    get { return _moped; }
	}
	
}