using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 对手信息 message
 */
public class ResLimitArenaOpponentMessage : Message 
{
	//对手信息
	LimitArenaOpponentInfo _oppoInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对手信息
		SerializeUtils.WriteBean(stream, _oppoInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对手信息
		_oppoInfo = SerializeUtils.ReadBean<LimitArenaOpponentInfo>(stream);
	}
	
	/**
	 * 对手信息
	 */
	public LimitArenaOpponentInfo OppoInfo
	{
		set { _oppoInfo = value; }
	    get { return _oppoInfo; }
	}
	
	
	public override int GetId() 
	{
		return 502101;
	}
}