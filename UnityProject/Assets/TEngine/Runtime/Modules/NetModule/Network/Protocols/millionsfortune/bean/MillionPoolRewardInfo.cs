using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 获取的玩家百万招财积分获取的奖池奖励信息
 */
public class MillionPoolRewardInfo : IMessageSerialize 
{
	//服务器名称
	string _serverName;	
	//玩家名称
	string _playerName;	
	//奖励物品编号
	int _itemId;	
	//奖励物品数量
	int _itemNum;	
	//到现在过去的秒数
	int _seconds;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//服务器名称
		SerializeUtils.WriteString(stream, _serverName);
		//玩家名称
		SerializeUtils.WriteString(stream, _playerName);
		//奖励物品编号
		SerializeUtils.WriteInt(stream, _itemId);
		//奖励物品数量
		SerializeUtils.WriteInt(stream, _itemNum);
		//到现在过去的秒数
		SerializeUtils.WriteInt(stream, _seconds);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//服务器名称
		_serverName = SerializeUtils.ReadString(stream);
		//玩家名称
		_playerName = SerializeUtils.ReadString(stream);
		//奖励物品编号
		_itemId = SerializeUtils.ReadInt(stream);
		//奖励物品数量
		_itemNum = SerializeUtils.ReadInt(stream);
		//到现在过去的秒数
		_seconds = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 服务器名称
	 */
	public string ServerName
	{
		set { _serverName = value; }
	    get { return _serverName; }
	}
	
	/**
	 * 玩家名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * 奖励物品编号
	 */
	public int ItemId
	{
		set { _itemId = value; }
	    get { return _itemId; }
	}
	
	/**
	 * 奖励物品数量
	 */
	public int ItemNum
	{
		set { _itemNum = value; }
	    get { return _itemNum; }
	}
	
	/**
	 * 到现在过去的秒数
	 */
	public int Seconds
	{
		set { _seconds = value; }
	    get { return _seconds; }
	}
	
}