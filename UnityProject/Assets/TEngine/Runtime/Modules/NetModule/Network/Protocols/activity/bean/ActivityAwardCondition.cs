using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 活动奖励条件
 */
public class ActivityAwardCondition : IMessageSerialize 
{
	//参数0
	int _param0;	
	//参数1
	int _param1;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//参数0
		SerializeUtils.WriteInt(stream, _param0);
		//参数1
		SerializeUtils.WriteInt(stream, _param1);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//参数0
		_param0 = SerializeUtils.ReadInt(stream);
		//参数1
		_param1 = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 参数0
	 */
	public int Param0
	{
		set { _param0 = value; }
	    get { return _param0; }
	}
	
	/**
	 * 参数1
	 */
	public int Param1
	{
		set { _param1 = value; }
	    get { return _param1; }
	}
	
}