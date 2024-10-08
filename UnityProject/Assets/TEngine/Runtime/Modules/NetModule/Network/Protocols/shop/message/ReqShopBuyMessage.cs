using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 购买道具 message
 */
public class ReqShopBuyMessage : Message 
{
	//商店类型(1:浦原商店, 2:竞技商店)
	int _type;	
	//序号
	int _index;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//商店类型(1:浦原商店, 2:竞技商店)
		SerializeUtils.WriteInt(stream, _type);
		//序号
		SerializeUtils.WriteInt(stream, _index);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//商店类型(1:浦原商店, 2:竞技商店)
		_type = SerializeUtils.ReadInt(stream);
		//序号
		_index = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商店类型(1:浦原商店, 2:竞技商店)
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 序号
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	
	public override int GetId() 
	{
		return 104202;
	}
}