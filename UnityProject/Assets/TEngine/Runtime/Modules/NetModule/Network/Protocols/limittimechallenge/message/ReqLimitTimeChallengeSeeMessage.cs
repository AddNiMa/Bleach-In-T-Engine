using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 知晓限时挑战超时消息 message
 */
public class ReqLimitTimeChallengeSeeMessage : Message 
{
	//限时挑战编号
	int _limitTimeChallengeId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//限时挑战编号
		SerializeUtils.WriteInt(stream, _limitTimeChallengeId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//限时挑战编号
		_limitTimeChallengeId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 限时挑战编号
	 */
	public int LimitTimeChallengeId
	{
		set { _limitTimeChallengeId = value; }
	    get { return _limitTimeChallengeId; }
	}
	
	
	public override int GetId() 
	{
		return 314202;
	}
}