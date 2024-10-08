using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 刷新灵力修炼信息 message
 */
public class ResOneAdvanceTrialInfoMessage : Message 
{
	//刷新单个灵力修炼信息
	int _passedAdvanceTrialId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//刷新单个灵力修炼信息
		SerializeUtils.WriteInt(stream, _passedAdvanceTrialId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//刷新单个灵力修炼信息
		_passedAdvanceTrialId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 刷新单个灵力修炼信息
	 */
	public int PassedAdvanceTrialId
	{
		set { _passedAdvanceTrialId = value; }
	    get { return _passedAdvanceTrialId; }
	}
	
	
	public override int GetId() 
	{
		return 224104;
	}
}