using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 限时挑战信息消息 message
 */
public class ResLimitTimeChallengeInfoMessage : Message 
{
	//限时挑战信息实例
	LimitTimeChallengeInfoIns _limitTimeChallengeInfoIns;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//限时挑战信息实例
		SerializeUtils.WriteBean(stream, _limitTimeChallengeInfoIns);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//限时挑战信息实例
		_limitTimeChallengeInfoIns = SerializeUtils.ReadBean<LimitTimeChallengeInfoIns>(stream);
	}
	
	/**
	 * 限时挑战信息实例
	 */
	public LimitTimeChallengeInfoIns LimitTimeChallengeInfoIns
	{
		set { _limitTimeChallengeInfoIns = value; }
	    get { return _limitTimeChallengeInfoIns; }
	}
	
	
	public override int GetId() 
	{
		return 314101;
	}
}