using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求刷新温泉 message
 */
public class ReqRefreshSpringMessage : Message 
{
	//温泉id
	int _springId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//温泉id
		SerializeUtils.WriteInt(stream, _springId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//温泉id
		_springId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 温泉id
	 */
	public int SpringId
	{
		set { _springId = value; }
	    get { return _springId; }
	}
	
	
	public override int GetId() 
	{
		return 306202;
	}
}