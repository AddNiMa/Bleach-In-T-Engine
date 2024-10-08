using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 更新单条宿命对决信息 message
 */
public class ResSingleDestinyInfoMessage : Message 
{
	//单条宿命对决信息
	DestinyInfo _destinyInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//单条宿命对决信息
		SerializeUtils.WriteBean(stream, _destinyInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//单条宿命对决信息
		_destinyInfo = SerializeUtils.ReadBean<DestinyInfo>(stream);
	}
	
	/**
	 * 单条宿命对决信息
	 */
	public DestinyInfo DestinyInfo
	{
		set { _destinyInfo = value; }
	    get { return _destinyInfo; }
	}
	
	
	public override int GetId() 
	{
		return 107103;
	}
}