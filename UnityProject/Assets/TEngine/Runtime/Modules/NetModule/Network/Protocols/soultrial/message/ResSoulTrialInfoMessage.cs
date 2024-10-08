using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 *  message
 */
public class ResSoulTrialInfoMessage : Message 
{
	//灵魂试炼信息
	SoulTrialInfo _soulTrialInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵魂试炼信息
		SerializeUtils.WriteBean(stream, _soulTrialInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵魂试炼信息
		_soulTrialInfo = SerializeUtils.ReadBean<SoulTrialInfo>(stream);
	}
	
	/**
	 * 灵魂试炼信息
	 */
	public SoulTrialInfo SoulTrialInfo
	{
		set { _soulTrialInfo = value; }
	    get { return _soulTrialInfo; }
	}
	
	
	public override int GetId() 
	{
		return 204101;
	}
}