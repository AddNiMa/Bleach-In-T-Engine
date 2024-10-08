using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 扫荡结果消息 message
 */
public class ResMopSoulTrialMessage : Message 
{
	//0:成功 ,1:玩家等级不够,2:vip等级不足,3:该轮已经扫荡过,4:可以扫荡的关卡已经都已经手动战斗过
	int _result;	
	//灵魂试炼扫荡奖励列表
	List<MopReward> _soulTrialMopReward = new List<MopReward>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:成功 ,1:玩家等级不够,2:vip等级不足,3:该轮已经扫荡过,4:可以扫荡的关卡已经都已经手动战斗过
		SerializeUtils.WriteInt(stream, _result);
		//灵魂试炼扫荡奖励列表
		SerializeUtils.WriteShort(stream, (short)_soulTrialMopReward.Count);

		foreach (var element in _soulTrialMopReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:成功 ,1:玩家等级不够,2:vip等级不足,3:该轮已经扫荡过,4:可以扫荡的关卡已经都已经手动战斗过
		_result = SerializeUtils.ReadInt(stream);
		//灵魂试炼扫荡奖励列表
		int _soulTrialMopReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _soulTrialMopReward_length; ++i) 
		{
			_soulTrialMopReward.Add(SerializeUtils.ReadBean<MopReward>(stream));
		}
	}
	
	/**
	 * 0:成功 ,1:玩家等级不够,2:vip等级不足,3:该轮已经扫荡过,4:可以扫荡的关卡已经都已经手动战斗过
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * get 灵魂试炼扫荡奖励列表
	 * @return 
	 */
	public List<MopReward> GetSoulTrialMopReward()
	{
		return _soulTrialMopReward;
	}
	
	/**
	 * set 灵魂试炼扫荡奖励列表
	 */
	public void SetSoulTrialMopReward(List<MopReward> soulTrialMopReward)
	{
		_soulTrialMopReward = soulTrialMopReward;
	}
	
	
	public override int GetId() 
	{
		return 204106;
	}
}