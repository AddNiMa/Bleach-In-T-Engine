using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 限时挑战领奖答复 message
 */
public class ResLimitTimeChallengeRewardMessage : Message 
{
	//限时挑战编号
	int _limitTimeChallengeId;	
	//0:成功,1:没有该编号的限时挑战,2:已经领取奖励,3:已经超时,4:还没有完成
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//限时挑战编号
		SerializeUtils.WriteInt(stream, _limitTimeChallengeId);
		//0:成功,1:没有该编号的限时挑战,2:已经领取奖励,3:已经超时,4:还没有完成
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//限时挑战编号
		_limitTimeChallengeId = SerializeUtils.ReadInt(stream);
		//0:成功,1:没有该编号的限时挑战,2:已经领取奖励,3:已经超时,4:还没有完成
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 限时挑战编号
	 */
	public int LimitTimeChallengeId
	{
		set { _limitTimeChallengeId = value; }
	    get { return _limitTimeChallengeId; }
	}
	
	/**
	 * 0:成功,1:没有该编号的限时挑战,2:已经领取奖励,3:已经超时,4:还没有完成
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 314102;
	}
}