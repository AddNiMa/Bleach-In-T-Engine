using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 登录活动奖励信息
 */
public class LoginRewardInfo : IMessageSerialize 
{
	//登录的第几天
	int _day;	
	//该天的奖励是否已经领取(0:未领取,非0:已领取)
	int _received;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//登录的第几天
		SerializeUtils.WriteInt(stream, _day);
		//该天的奖励是否已经领取(0:未领取,非0:已领取)
		SerializeUtils.WriteInt(stream, _received);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//登录的第几天
		_day = SerializeUtils.ReadInt(stream);
		//该天的奖励是否已经领取(0:未领取,非0:已领取)
		_received = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 登录的第几天
	 */
	public int Day
	{
		set { _day = value; }
	    get { return _day; }
	}
	
	/**
	 * 该天的奖励是否已经领取(0:未领取,非0:已领取)
	 */
	public int Received
	{
		set { _received = value; }
	    get { return _received; }
	}
	
}