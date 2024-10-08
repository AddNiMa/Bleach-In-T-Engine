using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回进入温泉结果消息 message
 */
public class ResEnterSpringMessage : Message 
{
	//进入温泉结果消息Id[0：成功,非0：失败的消息Id]
	int _msg;	
	//泡温泉角色
	List<int> _roles = new List<int>();
	//1:拿到幸运组合奖励 ,0:没有拿到幸运组合奖励
	byte _combinationReward;	
	//泡温泉的奖励信息
	List<MopReward> _reward = new List<MopReward>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//进入温泉结果消息Id[0：成功,非0：失败的消息Id]
		SerializeUtils.WriteInt(stream, _msg);
		//泡温泉角色
		SerializeUtils.WriteShort(stream, (short)_roles.Count);

		foreach (var element in _roles)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//1:拿到幸运组合奖励 ,0:没有拿到幸运组合奖励
		SerializeUtils.WriteByte(stream, _combinationReward);
		//泡温泉的奖励信息
		SerializeUtils.WriteShort(stream, (short)_reward.Count);

		foreach (var element in _reward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//进入温泉结果消息Id[0：成功,非0：失败的消息Id]
		_msg = SerializeUtils.ReadInt(stream);
		//泡温泉角色
		int _roles_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _roles_length; ++i) 
		{
			_roles.Add(SerializeUtils.ReadInt(stream));
		}
		//1:拿到幸运组合奖励 ,0:没有拿到幸运组合奖励
		_combinationReward = SerializeUtils.ReadByte(stream);
		//泡温泉的奖励信息
		int _reward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _reward_length; ++i) 
		{
			_reward.Add(SerializeUtils.ReadBean<MopReward>(stream));
		}
	}
	
	/**
	 * 进入温泉结果消息Id[0：成功,非0：失败的消息Id]
	 */
	public int Msg
	{
		set { _msg = value; }
	    get { return _msg; }
	}
	
	/**
	 * get 泡温泉角色
	 * @return 
	 */
	public List<int> GetRoles()
	{
		return _roles;
	}
	
	/**
	 * set 泡温泉角色
	 */
	public void SetRoles(List<int> roles)
	{
		_roles = roles;
	}
	
	/**
	 * 1:拿到幸运组合奖励 ,0:没有拿到幸运组合奖励
	 */
	public byte CombinationReward
	{
		set { _combinationReward = value; }
	    get { return _combinationReward; }
	}
	
	/**
	 * get 泡温泉的奖励信息
	 * @return 
	 */
	public List<MopReward> GetReward()
	{
		return _reward;
	}
	
	/**
	 * set 泡温泉的奖励信息
	 */
	public void SetReward(List<MopReward> reward)
	{
		_reward = reward;
	}
	
	
	public override int GetId() 
	{
		return 306101;
	}
}