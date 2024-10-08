using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应奖池奖励消息 message
 */
public class ResMillionPoolRewardInfoMessage : Message 
{
	//奖池奖励信息列表
	List<MillionPoolRewardInfo> _millionPoolRewardInfo = new List<MillionPoolRewardInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//奖池奖励信息列表
		SerializeUtils.WriteShort(stream, (short)_millionPoolRewardInfo.Count);

		foreach (var element in _millionPoolRewardInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//奖池奖励信息列表
		int _millionPoolRewardInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _millionPoolRewardInfo_length; ++i) 
		{
			_millionPoolRewardInfo.Add(SerializeUtils.ReadBean<MillionPoolRewardInfo>(stream));
		}
	}
	
	/**
	 * get 奖池奖励信息列表
	 * @return 
	 */
	public List<MillionPoolRewardInfo> GetMillionPoolRewardInfo()
	{
		return _millionPoolRewardInfo;
	}
	
	/**
	 * set 奖池奖励信息列表
	 */
	public void SetMillionPoolRewardInfo(List<MillionPoolRewardInfo> millionPoolRewardInfo)
	{
		_millionPoolRewardInfo = millionPoolRewardInfo;
	}
	
	
	public override int GetId() 
	{
		return 316103;
	}
}