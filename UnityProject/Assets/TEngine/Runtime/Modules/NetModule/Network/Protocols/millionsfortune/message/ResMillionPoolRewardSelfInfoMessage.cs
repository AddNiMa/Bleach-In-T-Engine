using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应自己奖池奖励消息 message
 */
public class ResMillionPoolRewardSelfInfoMessage : Message 
{
	//自己的奖池奖励信息
	MillionPoolRewardInfo _millionPoolRewardInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//自己的奖池奖励信息
		SerializeUtils.WriteBean(stream, _millionPoolRewardInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//自己的奖池奖励信息
		_millionPoolRewardInfo = SerializeUtils.ReadBean<MillionPoolRewardInfo>(stream);
	}
	
	/**
	 * 自己的奖池奖励信息
	 */
	public MillionPoolRewardInfo MillionPoolRewardInfo
	{
		set { _millionPoolRewardInfo = value; }
	    get { return _millionPoolRewardInfo; }
	}
	
	
	public override int GetId() 
	{
		return 316108;
	}
}