using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求领取探索奖励(真正结束探索) message
 */
public class ReqReceiveDiscoveryRewardMessage : Message 
{
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
	}
	
	
	public override int GetId() 
	{
		return 303202;
	}
}