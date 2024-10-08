using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回死神之力模块信息 message
 */
public class ResDeathpowerInfoMessage : Message 
{
	//当前死神之力
	int _curPowerId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//当前死神之力
		SerializeUtils.WriteInt(stream, _curPowerId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//当前死神之力
		_curPowerId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 当前死神之力
	 */
	public int CurPowerId
	{
		set { _curPowerId = value; }
	    get { return _curPowerId; }
	}
	
	
	public override int GetId() 
	{
		return 309102;
	}
}