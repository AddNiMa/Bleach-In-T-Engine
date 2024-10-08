using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领取的排行榜点数 message
 */
public class ResRankRewardMessage : Message 
{
	//领取的排行榜点数
	int _point;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//领取的排行榜点数
		SerializeUtils.WriteInt(stream, _point);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//领取的排行榜点数
		_point = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 领取的排行榜点数
	 */
	public int Point
	{
		set { _point = value; }
	    get { return _point; }
	}
	
	
	public override int GetId() 
	{
		return 209108;
	}
}