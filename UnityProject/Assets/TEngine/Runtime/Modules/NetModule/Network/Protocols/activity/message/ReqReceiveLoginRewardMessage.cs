using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领取登录奖励 message
 */
public class ReqReceiveLoginRewardMessage : Message 
{
	//领取登录奖励的天数(1-7)
	int _day;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//领取登录奖励的天数(1-7)
		SerializeUtils.WriteInt(stream, _day);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//领取登录奖励的天数(1-7)
		_day = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 领取登录奖励的天数(1-7)
	 */
	public int Day
	{
		set { _day = value; }
	    get { return _day; }
	}
	
	
	public override int GetId() 
	{
		return 311201;
	}
}