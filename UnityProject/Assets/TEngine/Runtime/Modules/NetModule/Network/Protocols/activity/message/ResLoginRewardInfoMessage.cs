using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 登录活动信息 message
 */
public class ResLoginRewardInfoMessage : Message 
{
	//登录活动信息
	List<LoginRewardInfo> _rewardInfos = new List<LoginRewardInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//登录活动信息
		SerializeUtils.WriteShort(stream, (short)_rewardInfos.Count);

		foreach (var element in _rewardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//登录活动信息
		int _rewardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rewardInfos_length; ++i) 
		{
			_rewardInfos.Add(SerializeUtils.ReadBean<LoginRewardInfo>(stream));
		}
	}
	
	/**
	 * get 登录活动信息
	 * @return 
	 */
	public List<LoginRewardInfo> GetRewardInfos()
	{
		return _rewardInfos;
	}
	
	/**
	 * set 登录活动信息
	 */
	public void SetRewardInfos(List<LoginRewardInfo> rewardInfos)
	{
		_rewardInfos = rewardInfos;
	}
	
	
	public override int GetId() 
	{
		return 311102;
	}
}