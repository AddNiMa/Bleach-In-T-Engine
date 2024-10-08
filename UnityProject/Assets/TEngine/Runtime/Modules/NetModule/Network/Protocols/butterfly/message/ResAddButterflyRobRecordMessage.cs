using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 增加单条地狱蝶抢夺纪录 message
 */
public class ResAddButterflyRobRecordMessage : Message 
{
	//地狱蝶抢夺纪录
	ButterflyRobRecord _butterflyRobRecord;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//地狱蝶抢夺纪录
		SerializeUtils.WriteBean(stream, _butterflyRobRecord);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//地狱蝶抢夺纪录
		_butterflyRobRecord = SerializeUtils.ReadBean<ButterflyRobRecord>(stream);
	}
	
	/**
	 * 地狱蝶抢夺纪录
	 */
	public ButterflyRobRecord ButterflyRobRecord
	{
		set { _butterflyRobRecord = value; }
	    get { return _butterflyRobRecord; }
	}
	
	
	public override int GetId() 
	{
		return 211207;
	}
}